﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NajibN.Sprint4.Task2.V21.Lib
{
    public class DataService : ISprint4Task2V21
    {
        public int Calculate(int[] array)
        {
            {
                int multArray = 1;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0)
                        multArray *= array[i];
                }
                return multArray;
            }
        }
    } }
