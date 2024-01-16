
namespace CharlesGrace_GUI_HW8
{
    public class Incident
    {
        /// <summary> A property containing a Product name</summary>
        public string Product { get; set; }

        /// <summary> A property containing the date an incident was opened</summary>
        public string DateOpened { get; set; }

        /// <summary> A property containing the date an incident was closed (may be null) </summary>
        public string DateClosed { get; set; }

        /// <summary> A property containing notes about an incident </summary>
        public string Title { get; set; }

        /// <summary> Creates a new instance of the Incident class. </summary>
        /// <param name="line"> a string passed from IncidentList.NewInstance </param>
        /// <returns> A new instance of the Incident class based on the provided line. </returns>
        public static Incident NewInstance(string line)
        {
            var tokens = line.Split('|');
            var incident = new Incident
            {
                Product = tokens[0],
                DateOpened = tokens[1],
                DateClosed = tokens[2],
                Title = tokens[3]
            };
            return incident;
        }

    }
}
