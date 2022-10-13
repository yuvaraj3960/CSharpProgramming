using System;

using System.Linq;
using System.Threading.Tasks;

namespace CollageAdmission3
{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        {
            
            
            Type [] Array2=new Type[_capacity+1];

            for(int i=0;i<_count;i++)
            {
                if(i<index)
                {
                    Array2[i]=Array[i];
                }

                else if(i==index)
                {
                    Array2[index]=data;
                    
                }
                else if(i>index)
                {
                    Array2[i]=Array[i-1];
                }
               
            }
             

        }

        public void RemoveAt(int index)
        {
            for(int i=index;i<_count-1;i++)
            {
            
                 Array[i]=Array[i+1];             
               
            }
            for(int i=0;i<_count-1;i++)
            {
                System.Console.WriteLine(Array[i]);
            
                             
               
            }

        }

        public void Remove(int values)
        {
            for(int i=0;i<_count-1;i++)
            {
                if(Array[i].Equals(values))
                {
                   
                    
                    for(int j=i;j<_count-1;j++)
                    {
                        Array[j]=Array[j+1];
                    }
                    

                }
                System.Console.WriteLine(Array[i]);
            }

        }
        
    }
}