﻿using LibAlpha.PrjOne;
using LibAlpha.PrjTwo;
using LibBeta.PrjOne;
using LibBeta.PrjTwo;

namespace AppTwo.Cmd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var libAlphaPrjOneClass = new LibAlphaPrjOneClass();
            var libAlphaPrjTwoClass = new LibAlphaPrjTwoClass();
            var libBetaPrjOneClass = new LibBetaPrjOneClass();
            var libBetaPrjTwoClass = new LibBetaPrjTwoClass();

            Console.WriteLine(
                libBetaPrjTwoClass.AppendName(
                    libBetaPrjOneClass.AppendName(
                        libAlphaPrjTwoClass.AppendName(
                            libAlphaPrjOneClass.AppendName("(M2)AppTwo.Cmd:")))));
        }
    }
}