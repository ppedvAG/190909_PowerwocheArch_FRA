﻿namespace Taschenrechner.Domain
{
    public interface IParser
    {
        Formel Parse(string input);
    }
}
