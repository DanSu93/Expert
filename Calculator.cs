using System;
using System.Collections.Generic;

namespace Expert
{
    public class ExpertData
    {
        public int ExpertNumber;
        public double[,] FND, Priority, TempData;
        public double[] Result;
        public List<double[,]> CriteriaData;
    }

    public class Calculator
    {
        void FNDMethod(List<ExpertData> data)
        {
            foreach (ExpertData ed in data)
            {
                int index = 0;
                foreach (double[,] cd in ed.CriteriaData)
                {
                    for (int i = 0; i < cd.GetLength(0); i++)
                    {
                        double max = 0;
                        for (int j = 0; j < cd.GetLength(1); j++)
                            if (max < (cd[j, i] - cd[i, j]))
                            {
                                max = cd[j, i] - cd[i, j];
                                ed.FND[index, i] = Math.Round((1 - max), 1);
                            }
                            else
                                ed.FND[index, i] = Math.Round((1 - max), 1);
                    }
                    index++;
                }
            }
        }

        void ExpResult(List<ExpertData> data)
        {
            foreach (ExpertData ed in data)
            {
                for (int i = 0; i < ed.TempData.GetLength(0); i++)
                {
                    double max = 0;
                    for (int j = 0; j < ed.TempData.GetLength(1); j++)
                        if (max < (ed.TempData[j, i] - ed.TempData[i, j]))
                        {
                            max = ed.TempData[j, i] - ed.TempData[i, j];
                            ed.Result[i] = Math.Round((1 - max), 1);
                        }
                        else
                            ed.Result[i] = Math.Round((1 - max), 1);
                }
                int length = 0;
                if (ed.TempData.Length >= ed.Priority.Length)
                    length = ed.Priority.GetLength(0);
                else
                    length = ed.TempData.GetLength(0);
                for (int i = 0; i < ed.TempData.GetLength(0); i++)
                    if (ed.TempData[i, i] != 1 && ed.Result[i] != 0)
                        for (int l = 0; l < length; l++)
                            for (int t = 0; t < length; t++)
                                if (ed.TempData[t, l] == 0)
                                    ed.Result[i] = 0;
            }
        }

        void ExpTempMethod(List<ExpertData> data)
        {
            foreach (ExpertData ed in data)
                for (int i = 0; i < ed.TempData.GetLength(0); i++)
                    for (int j = 0; j < ed.TempData.GetLength(1); j++)
                    {
                        double max = 0;
                        for (int l = 0; l < ed.FND.GetLength(0); l++)
                            for (int t = 0; t < ed.FND.GetLength(0); t++)
                            {
                                double min = 0;
                                min = ed.FND[l, i];
                                if (min >= ed.FND[t, j])
                                    min = ed.FND[t, j];
                                if (min >= ed.Priority[t, l])
                                    min = ed.Priority[t, l];
                                if (min >= max)
                                    max = min;
                            }
                        ed.TempData[j, i] = max;
                    }
        }

        public void Do(List<ExpertData> data)
        {
            FNDMethod(data);
            ExpTempMethod(data);
            ExpResult(data);
        }
    }
}
