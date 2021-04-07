using ConceptDemo.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Fundamentals
{
    public class Collections : IConceptDemo
    {
        public void ShowDemo()
        {
            ArrayListAnalysis();
            ListAnalysis();
            HashSetAnalysis();
            HashTableAnalysis();
            DictionaryAnalysis();
        }

        #region IList Based Collections
        private void ArrayListAnalysis()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            var arrayListCollection = new ArrayList { "Test", 1, 50.85, 'H' };

            DisplayIListBasedCollection(arrayListCollection);

            Console.WriteLine("\nArray list is a non generic collection of different data types.\nSize of the arraylist can be increase dynamically.\nIt implements IList interface, hence all the operations of IList interface can be performed on it.");

            Console.WriteLine(Utility.LineSeprator);
        }

        private void ListAnalysis()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            var stringList = new List<string>()
            {
                "Test 1", "Test 2", "Test 3"
            };

            DisplayIListBasedCollection(stringList);

            var intList = new List<int>()
            {
                1,2,3
            };

            DisplayIListBasedCollection(intList);

            Console.WriteLine("\nList is a generic collection of similar data types.\nSize of the list can be increase dynamically.\nIt implements IList interface, hence all the operations of IList interface can be performed on it.");

            Console.WriteLine(Utility.LineSeprator);
        }

        private void HashSetAnalysis()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            Console.WriteLine("HashSet Analysis...");
            var intHashSet = new HashSet<int> { 45, 88, 45 };

            DisplayIListBasedCollection(intHashSet);

            Console.WriteLine("HashSet stores distinct elements of same type only.");
            Console.WriteLine(Utility.LineSeprator);
        }

        #endregion


        #region IDictionary Based Collections
        private void HashTableAnalysis()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            Console.WriteLine("Hashtable analysis...");
            var hashTable = new Hashtable
            {
                {"Test", 1}, {5, "Test"}, {50.50, "Abc"}, {'c', 88}
            };

           DisplayIDictionaryBasedCollection(hashTable);

            Console.WriteLine("\nHashtable is a key value pair based collection like dictionary which contains different types of key and values for each key-value pair.\nIt implements IDictionary interface. Hence all operations available in the interface can be performed on Hashtable.\nIt can have key-value pair with duplicate keys.");
            Console.WriteLine(Utility.LineSeprator);
        }

        private void DictionaryAnalysis()
        {
            Console.WriteLine("\n" + Utility.LineSeprator);
            Console.WriteLine("Dictionary analysis...");
            var dictionary = new Dictionary<int, int>
            {
                {1, 1}, {2, 2}, {3, 3}
            };

            DisplayIDictionaryBasedCollection(dictionary);

            Console.WriteLine("\nDictionary is a key value pair based collection.\nIt implements IDictionary interface. Hence all operations available in the interface can be performed on Hashtable.\nKey-value pairs with duplicate keys can't be added.");
            Console.WriteLine(Utility.LineSeprator);
        }

        #endregion


        private void DisplayIListBasedCollection(IEnumerable collection)
        {
            Console.WriteLine("Collection Details:\n" + collection);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        private void DisplayIDictionaryBasedCollection(IDictionary dictionary)
        {
            Console.WriteLine("Collection Details:\n" + dictionary);
            foreach (DictionaryEntry dictionaryEntry in dictionary)
            {
                Console.WriteLine("key : " + dictionaryEntry.Key + ", value : " + dictionaryEntry.Value);
            }
        }
    }
}