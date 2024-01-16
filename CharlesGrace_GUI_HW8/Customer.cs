
namespace CharlesGrace_GUI_HW8
{
    public class Customer
    {
        /// <summary> A property containing a customer ID</summary>
        public string Id { get; set; }

        /// <summary> A property containing a customer name</summary>
        public string Name { get; set; }

        /// <summary> A property containing a customer's address</summary>
        public string Address { get; set; }

        /// <summary> A property containing a customer's city</summary>
        public string City { get; set; }

        /// <summary> A property containing a customer's state</summary>
        public string State { get; set; }

        /// <summary> A property containing a customer's zip code</summary>
        public string Zip { get; set; }

        /// <summary> A property containing a customer's phone number </summary>
        public string Phone { get; set; }

        /// <summary> A property containing a customer's email address </summary>
        public string Email { get; set; }

        /// <summary> Creates a new instance of the Customer class. </summary>
        /// <param name="customerId"> a string passed from Form1.CustomerIdTextBox.Text </param>
        /// <returns> A new instance of the Customer class based on the provided customer ID. </returns>
        public static Customer NewInstance(string customerId)
        {
            var fileName = $"customer{customerId}.txt";
            // want to only read the first line here, as all subsequent lines are Incidents. 
            using (var reader = new StreamReader(fileName))
            {
                var firstLine = reader.ReadLine();
                var tokens = firstLine.Split('|');

                var customer = new Customer
                    {
                        Id = tokens[0],
                        Name = tokens[1],
                        Address = tokens[2],
                        City = tokens[3],
                        State = tokens[4],
                        Zip = tokens[5],
                        Phone = tokens[6],
                        Email = tokens[7]
                        
                    };
                    return customer;
            }
        }

    }
}
