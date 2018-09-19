using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_ReQs
{
    internal class FrequencyDistribution<T>
    {
        //param li is the bag of words in a document
        //param itemValues is the distinct bag of words in both the documents that is being compared
        public FrequencyDistribution(List<T> wordsOfadocument, List<T> totalDistinctWords)
        {
            //Calculate the frequency of all words in document list wordsOfadocument
            CalcFreqDist(wordsOfadocument);
            // Represent the frequency of words not in the document but is in the other document as 0
            foreach (var v in totalDistinctWords)
            {
                if (!ItemFreq.Keys.Contains(v))
                {
                    ItemFreq.Add(v, new Item { value = v, count = 0 });
                }
            }
            // check that all values in wordsOfadocument are in the totalDistinctWords list
            foreach (var v in wordsOfadocument)
            {
                if (!totalDistinctWords.Contains(v))
                    throw new Exception(string.Format("Value in wordsOfadocument for frequency distribution not in the supplied totalDistinctWords '{0}'.", v));
            }
        }
        SortedList<T, Item> itemFreq = new SortedList<T, Item>();
        public SortedList<T, Item> ItemFreq { get { return itemFreq; } }
        // Find the distinct bag of words in the two documents
        public static List<T> GetDistinctValues(List<T> wordsOfadocument1, List<T> wordsOfadocument2)
        {
            return wordsOfadocument1.Concat(wordsOfadocument2).ToList().Distinct().ToList();
        }
        void CalcFreqDist(List<T> li)
        {
            itemFreq = new SortedList<T, Item>((from item in li
                                                group item by item into theGroup
                                                select new Item { value = theGroup.FirstOrDefault(), count = theGroup.Count() }).ToDictionary(q => q.value, q => q));
        }
        public class Item
        {
            public T value { get; set; }
            public int count { get; set; }
        }
    }
}
