using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class ArtikelController : ApiController
    {
        BookContext db = new BookContext();
        // POST api/Artikel
        public HttpStatusCode Post([FromBody]PostArtikel postArtikel)
        {
            try{
                if (!postArtikel.validate())
                {
                    throw new Exception();
                }
                Article a = new Article();
                a.Artikel = postArtikel.Artikel;
                a.Bezeichnung = postArtikel.Bezeichnung;
                a.Verkaufspreis = postArtikel.Verkaufspreis;
                a.TarifNr = postArtikel.Zolltarifnummer;
                a.kundenname = postArtikel.kundenname;
                a.land = postArtikel.Land;
                a.LS = postArtikel.Auftragsnummer;
                a.WaehrungNr = postArtikel.WaehrungNr;
                a.Einheit = postArtikel.Einheit;
                db.Articles.Add(a);
                if (postArtikel.Stucklisten.Count > 0)
                {
                    foreach (var p in postArtikel.Stucklisten)
                    {
                        Stuckliste s = new Stuckliste();
                        s.Anzahl = p.Anzahl;
                        s.Artikel = p.Artikel_S;
                        s.Bezeichnung = p.Bezeichnung_S;
                        s.Einkaufspreis = p.Einkaufspreis_S;
                        s.Lieferant = p.Lieferant;
                        s.Ursprungsland = p.Ursprungsland;
                        s.Praferenz = p.Praf_S;
                        s.Zolltarifnummer = p.Zolltarifnummer_S;
                        s.Parentid = a.Id;
                        s.EinheitNr = a.Einheit;
                        db.Stucklistes.Add(s);
                    }
                }
                db.SaveChanges();
                return HttpStatusCode.OK;
            }catch (Exception e)
            {
                Console.WriteLine(e);
                return HttpStatusCode.BadRequest;
            }


            //}catch (DbEntityValidationException e)
            //{
            //    foreach (var eve in e.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}catch (ModelValidationException e)
            //{

            //    return HttpStatusCode.BadRequest;
            //}catch(Exception e)
            //{
            //    Console.Write(e);
            //    return HttpStatusCode.BadGateway;
            //}


            //try
            //{
            //    if (Boolean.Parse(requestBody.Stuclistes.Count.ToString()))
            //    {
            //        return HttpStatusCode.OK;
            //    }
            //    else
            //    {
            //        throw new Exception();
            //    }
            //}
            //catch
            //{
            //        return HttpStatusCode.BadRequest;
            //}
        }
    }
}
