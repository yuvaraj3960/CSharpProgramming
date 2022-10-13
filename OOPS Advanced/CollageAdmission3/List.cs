using System;


namespace CollageAdmission3
{
    public partial class List<Type>
    {
        private Type[] Array{get;set;}
                   
        private int _count;

        private int _capacity;
        public int Count{get{return _count;}}

        public  int Capacity{get{return _capacity;}}

        public Type this[int i]{get{return Array[i];} set{Array[i]=value;}}
        

        public List()
        {
            _count=0;
            _capacity=4;
            Array=new Type[_capacity];
        }

        public void Add(Type a)
        {
            if(_count==_capacity)
            {
                GrowSize();

            }
            Array[_count]=a;
            _count++;

        }

        public void GrowSize()
        {
            Type[] Array1=new Type[_capacity*2];

            for(int i=0;i<_count;i++)
            {

             Array1[i]=Array[i];
            }
            Array=Array1;
            


        }

        
    }
}