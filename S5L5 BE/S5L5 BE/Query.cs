using System;
using System.Linq;

    public class Query
    {
 
        public static void varQuery()
        {
       
            var verbaliPerAnagrafe = dbContext.Verbali
                .GroupBy(v => v.Anagrafe)
                .Select(g => new { Anagrafe = g.Key, NumeroVerbaliTrascritti = g.Count() });
            foreach (var result in verbaliPerAnagrafe)
            {
                Console.WriteLine($"Anagrafe: {result.Anagrafe}, NumeroVerbaliTrascritti: {result.NumeroVerbaliTrascritti}");
            }

          
            var verbaliPerTipoViolenza = dbContext.Verbali
                .GroupBy(v => v.TipoViolenza)
                .Select(g => new { TipoViolenza = g.Key, NumeroVerbaliTrascritti = g.Count() });
            foreach (var result in verbaliPerTipoViolenza)
            {
                Console.WriteLine($"TipoViolenza: {result.TipoViolenza}, NumeroVerbaliTrascritti: {result.NumeroVerbaliTrascritti}");
            }

       
            var totalePuntiDecurtatiPerAnagrafe = dbContext.Verbali
                .GroupBy(v => v.Anagrafe)
                .Select(g => new { Anagrafe = g.Key, TotalePuntiDecurtati = g.Sum(v => v.PuntiDecurtati) });
            foreach (var result in totalePuntiDecurtatiPerAnagrafe)
            {
                Console.WriteLine($"Anagrafe: {result.Anagrafe}, TotalePuntiDecurtati: {result.TotalePuntiDecurtati}");
            }

            
            var verbaliResidentiPalermo = dbContext.Verbali
                .Where(v => v.Residenza == "Palermo")
                .Select(v => new { v.Cognome, v.Nome, v.DataViolazione, v.Indirizzo, v.Importo, v.PuntiDecurtati });
            foreach (var result in verbaliResidentiPalermo)
            {
                Console.WriteLine($"Cognome: {result.Cognome}, Nome: {result.Nome}, DataViolazione: {result.DataViolazione}, Indirizzo: {result.Indirizzo}, Importo: {result.Importo}, PuntiDecurtati: {result.PuntiDecurtati}");
            }

         
            var verbaliTraDate = dbContext.Verbali
                .Where(v => v.DataViolazione >= new DateTime(2009, 2, 1) && v.DataViolazione <= new DateTime(2009, 7, 31))
                .Select(v => new { v.Cognome, v.Nome, v.Indirizzo, v.DataViolazione, v.Importo, v.PuntiDecurtati });
            foreach (var result in verbaliTraDate)
            {
                Console.WriteLine($"Cognome: {result.Cognome}, Nome: {result.Nome}, Indirizzo: {result.Indirizzo}, DataViolazione: {result.DataViolazione}, Importo: {result.Importo}, PuntiDecurtati: {result.PuntiDecurtati}");
            }

         
            var totaleImportiPerAnagrafe = dbContext.Verbali
                .GroupBy(v => v.Anagrafe)
                .Select(g => new { Anagrafe = g.Key, TotaleImporti = g.Sum(v => v.Importo) });
            foreach (var result in totaleImportiPerAnagrafe)
            {
                Console.WriteLine($"Anagrafe: {result.Anagrafe}, TotaleImporti: {result.TotaleImporti}");
            }

            
            var anagraficiResidentiPalermo = dbContext.Anagrafica
                .Where(a => a.Residenza == "Palermo");
            foreach (var result in anagraficiResidentiPalermo)
            {
                Console.WriteLine($"Anagrafica: {result}");
            }

            
            var verbaliPerData = dbContext.Verbali
                .Where(v => v.DataViolazione == dataDaSpecificare)
                .Select(v => new { v.DataViolazione, v.Importo, v.PuntiDecurtati });
            foreach (var result in verbaliPerData)
            {
                Console.WriteLine($"DataViolazione: {result.DataViolazione}, Importo: {result.Importo}, PuntiDecurtati: {result.PuntiDecurtati}");
            }

          
            var violazioniPerAgente = dbContext.Verbali
                .GroupBy(v => v.AgenteDiPolizia)
                .Select(g => new { AgenteDiPolizia = g.Key, NumeroViolazioniContestate = g.Count() });
            foreach (var result in violazioniPerAgente)
            {
                Console.WriteLine($"AgenteDiPolizia: {result.AgenteDiPolizia}, NumeroViolazioniContestate: {result.NumeroViolazioniContestate}");
            }

            
            var violazioniConPuntiDecurtatiAlti = dbContext.Verbali
                .Where(v => v.PuntiDecurtati > 5)
                .Select(v => new { v.Cognome, v.Nome, v.Indirizzo, v.DataViolazione, v.Importo, v.PuntiDecurtati });
            foreach (var result in violazioniConPuntiDecurtatiAlti)
            {
                Console.WriteLine($"Cognome: {result.Cognome}, Nome: {result.Nome}, Indirizzo: {result.Indirizzo}, DataViolazione: {result.DataViolazione}, Importo: {result.Importo}, PuntiDecurtati: {result.PuntiDecurtati}");
            }

         
            var violazioniConImportoAlto = dbContext.Verbali
                .Where(v => v.Importo > 400)
                .Select(v => new { v.Cognome, v.Nome, v.Indirizzo, v.DataViolazione, v.Importo, v.PuntiDecurtati });
            foreach (var result in violazioniConImportoAlto)
            {
                Console.WriteLine($"Cognome: {result.Cognome}, Nome: {result.Nome}, Indirizzo: {result.Indirizzo}, DataViolazione: {result.DataViolazione}, Importo: {result.Importo}, PuntiDecurtati: {result.PuntiDecurtati}");
            }
        }
    }

    
