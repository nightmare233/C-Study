using System;

namespace CodeDev
{
    public class Box
    {
        //构造函数
        public Box(){

        }

        //原来的正常的写法：
        private string _name;
        private int _age;

        public String Name{
            get{
                return _name;
                }
            set{
                _name = value;
            }
        }

        public int Age{
            get{
                return _age;
            }
            set{
                _age = value;
            }
        }


        //自动属性
        public String Title{get;set;}
        public string Readers{get;set;}

        public string GetBoxName()
        {
            return this.Name+"-"+Age+" you got it by class internal method...";
        }
    }   
}