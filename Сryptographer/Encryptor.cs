﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сryptographer
{
    public delegate char EncyrptFunction(char c);
    class Encryptor
    {
        public EncyrptFunction encryptFunc;
        public string name;
        public string key;
        public Encryptor(EncyrptFunction func, string name, string key)
        {
            encryptFunc = func;
            this.name = name;
            this.key = key;
        }

        public char Encrypt(char symbol)
        {
            return encryptFunc(symbol);
        }
    }
}
