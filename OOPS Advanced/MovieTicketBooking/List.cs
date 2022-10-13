using System;
using System.Collections;

using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class List<Type>
    {
        private  int _count;
        private  int _capacity;
        public int Count{get{ return _count;}}
        public int Capacity{get{return _capacity;}}

        public Type[] Array{get;set;}

        public Type this [int i]{get {return Array[i];} set{ Array[i]=value;}}

        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];

        }

        public void Add(Type data)
        {
            if(_count==_capacity)
            {
             GrowSize();

            }
            Array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {  
             _capacity*=2;
            Type[] Array1=new Type[_capacity];
            for(int i=0;i<Count;i++)
            {
                Array1[i]=Array[i];
            }
            Array=Array1;
        }

        
    }
}