using System;
using System.Collections.Generic;
using System.Text;

namespace ListMerger
{
    class MergeList
    {
        public static List<T> Merge<T>(List<T> list1, List<T> list2) where T : IComparable<T>
        {
            List<T> mergedList = new List<T>();

            var list1Id = 0;
            var list2Id = 0;


            for (int i = 0; i < list1.Count + list2.Count; i++)
            {
                if(list1Id >= list1.Count)
                {
                    for (int j = list2Id; j < list2.Count; j++)
                    {
                        mergedList.Add(list2[j]);
                    }
                    return mergedList;
                }else if (list2Id >= list2.Count)
                {
                    for (int j = list1Id; j < list1.Count; j++)
                    {
                        mergedList.Add(list1[j]);
                    }
                    return mergedList;
                }

                if(list1[list1Id].CompareTo(list2[list2Id]) <= 0)
                {
                    mergedList.Add(list1[list1Id]);
                    list1Id++;
                }
                else
                {
                    mergedList.Add(list2[list2Id]);
                    list2Id++;
                }

            }

            return mergedList;
        }
    }
}
