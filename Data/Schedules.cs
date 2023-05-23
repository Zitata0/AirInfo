using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirInfo.Data
{
    internal class Schedules
    {
        private int id;

        private string airlineIata;
        private string airlineIcao;

        private string flightIata;
        private string flightIcao;
        private string flightNumber;

        private string depIata;
        private string depIcao;
        private string depTerminal;
        private string depGate;
        private string depTime;
        private string depTimeUtc;
        private string depEstimated;
        private string depEstimatedUtc;
        private string depActual;
        private string depActualUtc;

        private string arrIata;
        private string arrIcao;
        private string arrTerminal;
        private string arrGate;
        private string arrBaggage;
        private string arrTime;
        private string arrTimeUtc;
        private string arrEstimated;
        private string arrEstimatedUtc;

        private string csAirlineIata;
        private string csFlightNumber;
        private string csFlightIata;
        private string aircraftIcao;

        private string status;

        private int duration;
        private int delayed;
        private int depDelayed;
        private int arrDelayed;

        private int arrTimeTs;
        private int depTimeTs;
        private int arrEstimatedTs;
        private int depEstimatedTs;
        private int arrActualTs;
        private int depActualTs;

        public Schedules(
            int id,

            string airlineIata,
            string airlineIcao,

            string flightIata,
            string flightIcao,
            string flightNumber,

            string depIata,
            string depIcao,
            string depTerminal,
            string depGate,
            string depTime,
            string depTimeUtc,
            string depEstimated,
            string depEstimatedUtc,
            string depActual,
            string depActualUtc,

            string arrIata,
            string arrIcao,
            string arrTerminal,
            string arrGate,
            string arrBaggage,
            string arrTime,
            string arrTimeUtc,
            string arrEstimated,
            string arrEstimatedUtc,

            string csAirlineIata,
            string csFlightNumber,
            string csFlightIata,
            string aircraftIcao,

            string status,

            int duration,
            int delayed,
            int depDelayed,
            int arrDelayed,

            int arrTimeTs,
            int depTimeTs,
            int arrEstimatedTs,
            int depEstimatedTs,
            int arrActualTs,
            int depActualTs
            )
        {
            this.id = id;

            this.airlineIata = airlineIata;
            this.airlineIcao = airlineIcao;

            this.flightIata = flightIata;
            this.flightIcao = flightIcao;
            this.flightNumber = flightNumber;

            this.depIata = depIata;
            this.depIcao = depIcao;
            this.depTerminal = depTerminal;
            this.depGate = depGate;
            this.depTime = depTime;
            this.depTimeUtc = depTimeUtc;
            this.depEstimated = depEstimated;
            this.depEstimatedUtc = depEstimatedUtc;
            this.depActual = depActual;
            this.depActualUtc = depActualUtc;

            this.arrIata = arrIata;
            this.arrIcao = arrIcao;
            this.arrTerminal = arrTerminal;
            this.arrGate = arrGate;
            this.arrBaggage = arrBaggage;
            this.arrTime = arrTime;
            this.arrTimeUtc = arrTimeUtc;
            this.arrEstimated = arrEstimated;
            this.arrEstimatedUtc = arrEstimatedUtc;

            this.csAirlineIata = csAirlineIata;
            this.csFlightNumber = csFlightNumber;
            this.csFlightIata = csFlightIata;

            this.status = status;

            this.duration = duration;
            this.delayed = delayed;
            this.depDelayed = depDelayed;
            this.arrDelayed = arrDelayed;
            this.aircraftIcao = aircraftIcao;

            this.arrTimeTs = arrTimeTs;
            this.depTimeTs = depTimeTs;
            this.arrEstimatedTs = arrEstimatedTs;
            this.depEstimatedTs = depEstimatedTs;
            this.arrActualTs = arrActualTs;
            this.depActualTs = depActualTs;
        }
        public int Id
        {
            get { return this.id; }
        }
        public string AirlineIata
        {
            get { return this.airlineIata; }
        }
        public string FlightNumber
        {
            get { return this.flightNumber; }
        }
        public string DepIata
        {
            get { return this.depIata; }
        }
        public string DepTime
        {
            get { return this.depTime; }
        }
        public string ArrIata
        {
            get { return arrIata; }
        }
        public string ArrTime
        {
            get { return this.arrTime; }
        }
        public string Status
        {
            get { return this.status; }
        }
    }
}
