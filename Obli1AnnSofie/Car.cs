namespace CarClassLibary
{
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int Price { get; set; }
        public string LicensePlate { get; set; }

        public void ValidateId()
        {
            if (Id == 0) throw new ArgumentException("Id can't be 0!");
        }

        public void ValidateModel()
        {
            if (Model?.Length < 4)
                throw new ArgumentOutOfRangeException("Model lenght can't be under 4 characters!");
        }

        public void ValidatePrice()
        {
            if (Price < 0) throw new ArgumentOutOfRangeException("Price can't be a negative number!");
        }

        public void ValidateLicensePlate()
        {
            if (LicensePlate.Length <= 2) throw new ArgumentOutOfRangeException("Licence Plate has to be more than 2 numbers!");
            if (LicensePlate.Length >= 7) throw new ArgumentOutOfRangeException("License Plate can't be more than 6 numbers!");
        }

        public void Validate()
        {
            ValidateModel();
            ValidatePrice();
            ValidateLicensePlate();
        }

    }
}