using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Widerstandsmessung.Data.EF;
using Widerstandsmessung.Domain;
using Widerstandsmessung.Logic;

namespace Widerstandsmessung.UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1) Jede DLL laden, die im PlugIn-Ordner drinnen ist
            foreach (var file in Directory.GetFiles(".\\PlugIn"))
            {
                if (Path.GetExtension(file) == ".dll")
                    Assembly.LoadFrom(file);
            }

            var allAssemblies = AppDomain.CurrentDomain.GetAssemblies()
                                                        .Where(x => x.FullName.StartsWith("Widerstand"))
                                                        .ToArray();
            var allTypes = allAssemblies.SelectMany(x => x.GetTypes())
                                        .Where(x => typeof(IMesstechnik).IsAssignableFrom(x) &&
                                                    x.IsInterface == false &&
                                                    x.IsAbstract == false)
                                        .ToArray();
            // 2) Instanz von der Messtechnik erstellen
            IMesstechnik software = (IMesstechnik)Activator.CreateInstance(allTypes[0]); // zur laufzeit geladen
            IRepository repository = new EFRepository(new EFContext());
            messgerät = new Messgerät(software, repository);

            // Testdaten generieren falls keine da sein sollten
            if (repository.GetAll<SOLLWiderstand>().Count() == 0)
                GenerateTestData(repository);

            // Daten in der ListBox anzeigen
            listBoxSOLL.DataSource = repository.GetAll<SOLLWiderstand>();

            // Software laden
            comboBoxSoftware.Items.Clear();
            foreach (var item in allTypes)
            {
                comboBoxSoftware.Items.Add(item);
            }
            comboBoxSoftware.SelectedIndex = 0;
        }

        private Messgerät messgerät;

        private void GenerateTestData(IRepository repository)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                SOLLWiderstand soll = new SOLLWiderstand();
                soll.UV = r.NextDouble();
                soll.UW = r.NextDouble();
                soll.VW = r.NextDouble();

                repository.Add(soll);
            }
            repository.Save();
        }

        private void ListBoxSOLL_SelectedIndexChanged(object sender, EventArgs e)
        {
            SOLLWiderstand aktuellerWiderstand = listBoxSOLL.SelectedItem as SOLLWiderstand;

            labelUV.Text = aktuellerWiderstand.UV.ToString();
            labelUW.Text = aktuellerWiderstand.UW.ToString();
            labelVW.Text = aktuellerWiderstand.VW.ToString();

            labelMittelwert.Text = ((aktuellerWiderstand.UV + aktuellerWiderstand.UW + aktuellerWiderstand.VW) / 3).ToString();
        }

        private void ButtonISTBerechnen_Click(object sender, EventArgs e)
        {
            var ist = messgerät.Software.Berechne(listBoxSOLL.SelectedItem as SOLLWiderstand);
            textBoxLog.Text = ($"Ist-Widerstand:{Environment.NewLine}UV:{ist.UV}{Environment.NewLine}UW:{ist.UW}{Environment.NewLine}VW:{ist.VW}{Environment.NewLine}Mittelwert:{ist.Mittelwert}");

            if(messgerät.Software is IMesstechnikV2 v2)
            {
                var istMitSpitzenwert = v2.Spitzenwert(listBoxSOLL.SelectedItem as SOLLWiderstand);
                textBoxLog.Text += $"{Environment.NewLine}Spitzenwert: {istMitSpitzenwert.Spitzenwert}";
            }
        }

        private void ComboBoxSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            messgerät.Software = (IMesstechnik)Activator.CreateInstance((Type)comboBoxSoftware.SelectedItem);
        }
    }
}
