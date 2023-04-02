using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethods
{
    public static class Utilities
    {
        
        //Użycie tego rozszerzenia zapewnia ucinanie samogłosek z danego stringa.
        public static string BezSamoglosek(this string sentence)
        {
            var samogloski = new string[] { "a", "e", "i", "o", "u", "ó", "y", "ą", "ę" };
            
            foreach (string samogloska in samogloski)
            {
                if (sentence.Contains(samogloska))
                {
                    sentence = sentence.Replace(samogloska, string.Empty);
                }
                else if (sentence.Contains(samogloska.ToUpper()))
                {
                    sentence = sentence.Replace(samogloska.ToUpper(), string.Empty);
                }
            }

            return sentence;

        }

        //Użycie tego rozszerzenia pozwala sprawdzić, czy string jest konwertowalny na liczbę.
        public static bool IsNumeric(this string sentence)
        {
            double result;
            return double.TryParse(sentence, out result);

        }

        //Użycie tego rozszerzenia pozwala wypisać elementy lista w formacie {{1}, {2}, {3}, ...}.
        public static string Dump<T>(this IList<T> group)
        {
            string write = string.Join(", ", group);

            return $"{{{write}}}";
            
        }

        //IEnumerable to inaczej iterator przechodzący np.przez listę !
        //Użycie tego rozszerzenia zapewnia wypisanie każdego elementu np.listy w oddzielnych liniach konsoli.
        public static void PrintLn<T>(this IEnumerable<T> sequence) 
        {
            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }


        //Użycie tego rozszerzenia pozwala na uzyskanie mediany z ciągu liczb całkowitych.
        public static double Median(this IEnumerable<int> sequence)
        {
            var sortedSequence = sequence.OrderBy(x => x);
            int count = sortedSequence.Count();

            if (count == 0)
                throw new InvalidOperationException("Sequence contains no elements");

            int middleIndex = count / 2;
            double median = count % 2 != 0 ? sortedSequence.ElementAt(middleIndex)
                                           : (sortedSequence.ElementAt(middleIndex - 1) +
                                              sortedSequence.ElementAt(middleIndex)) / 2.0;
            return median;

            
        }


        //Użycie tego rozszerzenia pozwala na sprawdzenie czy wartość znajduje się w zakresie.
        public static bool Between<T>(this T value, T lower, T upper) where T : IComparable<T>
        {
            return value.CompareTo(lower) >= 0 && value.CompareTo(upper) <= 0;
        }


        //Rozszerzenie funkcji Between o delegat.
        public static bool Between<T>(this T value, T lower, T upper, Comparison<T> comparer)
        {
            return comparer(value, lower) >= 0 && comparer(value, upper) <= 0;
        }




    }
}
