using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumObject
{
    internal class Otaxi
    {
        public String name {  get; set; }
        public int Id { get; set; }
        public Gender gender { get; set; }
        public CarType carType { get; set; }

        public Otaxi(string name,int Id, Gender gender,CarType carType)
        {
            this.name = name;
            this.Id = Id;
            this.gender = gender;
            this.carType = carType;
        }
    }
    enum Gender
    {
        MALE,
        FEMALE,
    }
    enum CarType
    {
        [Description("it hase comfortable seats")]//attributes
        CAR=100,//#is attributes
        [Description("it hase not comfortable seats")]
        VAN = 223,
        [Description("it has not aire condition")]
        MOTERCYCLE = 432
    }
}
