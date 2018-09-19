using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_ReQs
{
    class CosineSimilarity
    {
        public static double cosineDistance<T>(List<T> l1, List<T> l2)
        {
            if (l1.Count() == 0 || l2.Count() == 0)
            {
                throw new Exception("Cosine Distance: lists cannot be zero length");
            }
            // find distinct list of items from two documents, used to align frequency distributions from two lists
            
            List<T> dvs = FrequencyDistribution<T>.GetDistinctValues(l1, l2);
            // calculate frequency distributions for each list.
            FrequencyDistribution<T> fd1 = new FrequencyDistribution<T>(l1, dvs);
            FrequencyDistribution<T> fd2 = new FrequencyDistribution<T>(l2, dvs);
           
            if (fd1.ItemFreq.Count() != fd2.ItemFreq.Count())
            {
                throw new Exception("Cosine Distance: Frequency count vectors must be same length");
            }
            double dotProduct = 0.0;
            double l2norm1 = 0.0;
            double l2norm2 = 0.0;
            for (int i = 0; i < fd1.ItemFreq.Values.Count(); i++)
            {
                if (!EqualityComparer<T>.Default.Equals(fd1.ItemFreq.Values[i].value, fd2.ItemFreq.Values[i].value))
                {
                    
                    throw new Exception("Mismatched values in frequency distribution for Cosine distance calculation");
                }
                    

                dotProduct += fd1.ItemFreq.Values[i].count * fd2.ItemFreq.Values[i].count;
                l2norm1 += fd1.ItemFreq.Values[i].count * fd1.ItemFreq.Values[i].count;
                l2norm2 += fd2.ItemFreq.Values[i].count * fd2.ItemFreq.Values[i].count;
            }
            double cos = dotProduct / (Math.Sqrt(l2norm1) * Math.Sqrt(l2norm2));
            // convert cosine value to radians then to degrees
            return cos;
            
        }
    }
}

