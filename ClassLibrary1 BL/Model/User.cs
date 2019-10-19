using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_BL.Model
{
    public class User
    {/// <summary>
    /// User
    /// </summary>
        public string Name { get; }
        public Gender Gender { get; }
        public DateTime Birthdate { get; }
        public DateTime BirthDate { get; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public User(string name, 
            Gender gender, 
            DateTime birthdate, 
            double weight, 
            double height)
        {
            #region exception checking
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("The name is wrong", nameof(name));

            }
            if (gender == null)
            {
                throw new ArgumentNullException("Gender is wrong", nameof(gender));
            }
            if (birthdate < DateTime.Parse("01.01.1900") || birthdate >=DateTime.Now)
            {
                throw new ArgumentException("Date is wrong", nameof(birthdate));
            }
            if(weight<=0)
            {
                throw new ArgumentException("Weight is wrong", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("height is wrong", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            Birthdate = birthdate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
