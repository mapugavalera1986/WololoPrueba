﻿namespace WololoPrueba.Excepciones
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string mensaje) : base(mensaje) { }
    }
}
