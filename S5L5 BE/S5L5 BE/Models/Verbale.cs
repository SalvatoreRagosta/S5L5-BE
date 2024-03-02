using System;
using System.Collections.Generic;

namespace S5L5_BE
{

    public class Verbale
    {
        public int idverbale { get; set; }
        public int DataViolazione { get; set; }
        public int IndirizzoViolazione { get; set; }
        public int Nominativo_Agente { get; set; }
        public DateTime DataTrascrizioneVerbale { get; set; }
        public decimal Importo { get; set; }
        public int DecurtamentoPunti { get; set; }
        public int idanagrafica { get; set; }
        public int idviolazione { get; set; }

    }
}
