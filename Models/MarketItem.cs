using DarkEdenWebsite.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DarkEdenWebsite.Models
{
    public class MarketItem
    {
        public MarketItem(int Id, string Name, float Discount, float Price,
            string Description, byte[] Image, Race Race, Gender Gender,
            DateTime AddedToMarket, DateTime DateBought, TimeSpan TimeLimit)
        {
            this.AddedToMarket = AddedToMarket;
            this.DateBought = DateBought;
            this.Description = Description;
            this.Discount = Discount;
            this.Gender = Gender;
            this.Id = Id;
            this.Image = Image;
            this.Name = Name;
            this.Price = Price;
            this.Race = Race;
            this.TimeLimit = TimeLimit;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public float Discount { get; set; }
        private float _Price;
        public float Price
        {
            get { return _Price - Discount; }
            set { _Price = value; }
        }
        
        public string Description { get; set; }
        public byte[] Image { get; set; }
        public Race Race { get; set; }
        public Gender Gender { get; set; }
        public DateTime AddedToMarket { get; set; }
        public DateTime DateBought { get; set; }
        public TimeSpan TimeLimit{ get; set; }
        public TimeSpan TimeLeft { get { return DateBought - DateBought.Add(TimeLimit); } }
        

        public override int GetHashCode()
        {
            int prime = 31;
            int result = 1;
            result = prime * result + Id.BitShiftThenBitOr(prime);
            result = prime * result + Name.StringToInt().BitShiftThenBitOr(prime);
            result = prime * result + Description.StringToInt().BitShiftThenBitOr(prime);
            result = prime * result + _Price.ToString().StringToInt().BitShiftThenBitOr(prime);
            result = prime * result + Discount.ToString().StringToInt().BitShiftThenBitOr(prime);
            result = prime * result + Race.RaceToInt().BitShiftThenBitOr(prime);
            result = prime * result + Gender.GenderToInt().BitShiftThenBitOr(prime);
            result = prime * result + AddedToMarket.DateToInt().BitShiftThenBitOr(prime);
            result = prime * result + DateBought.DateToInt().BitShiftThenBitOr(prime);
            result = prime * result + TimeLimit.TimeToInt().BitShiftThenBitOr(prime);
            result = prime * result + TimeLeft.TimeToInt().BitShiftThenBitOr(prime);
            result = prime * result + Convert.ToInt32(Image).BitShiftThenBitOr(prime);
            return result;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return false;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}