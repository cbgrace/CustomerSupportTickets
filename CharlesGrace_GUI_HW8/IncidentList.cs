
using System.Collections;

namespace CharlesGrace_GUI_HW8
{
    public class IncidentList : IEnumerable<Incident>
    {
        /// <summary> A field representing a list of customer incidents </summary>
        private List<Incident> incidents = new();

        /// <summary> A property to hold a list of customer incidents </summary>
        public List<Incident> Incidents => incidents;

        /// <summary> Gives the IncidentList class the ability to be enumerable </summary>
        /// <returns> incidents.GetEnumerator() </returns>
        public IEnumerator<Incident> GetEnumerator() => incidents.GetEnumerator();

        /// <summary> Gives the IncidentList class the ability to be enumerable </summary>
        /// <returns> GetEnumerator() </returns>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary> Creates a new instance of the IncidentList class. </summary>
        /// <param name="customerId"> a string passed from Form1.CustomerIdTextBox.Text </param>
        /// <returns> A new instance of the IncidentList class based on the provided customer ID. </returns>
        public static IncidentList NewInstance(string customerId)
        {
            var list = new IncidentList();
            var fileName = $"customer{customerId}.txt";
            using (var reader = new StreamReader(fileName))
            {
                var line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    list.Incidents.Add(Incident.NewInstance(line));
                }
            }
            return list;
        }
    }
}
