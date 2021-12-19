using Neo4jClient;
using Neo4jClient.Cypher;
using Newtonsoft.Json;
using Probaaaa.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Probaaaa
{
    public static class Neo4JData
    {
        private static GraphClient client;
        private static string directoryPath = Environment.CurrentDirectory + "\\res";

        public static GraphClient Client
        {
            get
            {
                if (client == null)
                {
                    client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "pass");
                    try
                    {
                        client.Connect();
                        //MessageBox.Show("Successfully connected!");
                    }
                    catch (Exception exc)
                    {

                    }
                }
                return client;
            }
        }

        private static String getMaxId()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n) where exists(n.id) return max(n.id)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxId = ((IRawGraphClient)Client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxId;
        }

        #region Proizvod
        //not used!
        private static String getMaxPictureName()
        {
            ///////////////////promeniti upite na novi format - ne ide sa start!!!
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n) WHERE EXISTS (n.img) RETURN max(n.img)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            String maxName = ((IRawGraphClient)Client).ExecuteGetCypherResults<String>(query).ToList().FirstOrDefault();

            return maxName;
        }

        public static List<Proizvod> dobaviSveProizvode()
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Proizvod) RETURN n LIMIT 25",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Proizvod> proizvodi = ((IRawGraphClient)Client).ExecuteGetCypherResults<Proizvod>(query).ToList();

            return proizvodi;
        }

        public static Proizvod AddProizvod(Proizvod p)
        {
            string maxId = getMaxId(); 

            try
            {
                int mId = Int32.Parse(maxId);
                p.id = (mId+1).ToString();
            }
            catch (Exception)
            {
                p.id = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("name", p.name);
            queryDict.Add("type", p.type);
            queryDict.Add("cost", p.cost);
            queryDict.Add("proizvodjac", p.proizvodjac);
            queryDict.Add("opis", p.opis);
            queryDict.Add("rating", p.rating); ////////
            queryDict.Add("wishes", p.wishes); ////////
            queryDict.Add("img", p.img); ////////

            var query = new Neo4jClient
                .Cypher
                .CypherQuery("CREATE (n:Proizvod {id:'" + p.id
                                                    + "', name:'" + p.name
                                                    + "', type:'" + p.type
                                                    + "', cost:'" + p.cost
                                                    + "', proizvodjac:'" + p.proizvodjac
                                                    + "', opis:'" + p.opis
                                                    + "', img:'" + p.img
                                                    + "', rating:'" + p.rating
                                                    + "', wishes:'" + p.wishes
                                                    + "'}) return n",
                              queryDict, CypherResultMode.Set);

            List<Proizvod> proizvodi = ((IRawGraphClient)Client).ExecuteGetCypherResults<Proizvod>(query).ToList();

            return p; //p kom smo dodali id
        }

        public static Proizvod GetProizvodFromId(String id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Proizvod {id:'" + id + "'}) RETURN n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            Proizvod result = ((IRawGraphClient)Client).ExecuteGetCypherResults<Proizvod>(query).ToList().FirstOrDefault();

            return result;
        }

        #endregion

        #region Kolekcija

        public static List<Kolekcija> dobaviSveKolekcije()
        {

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Kolekcija) RETURN n LIMIT 25",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Kolekcija> kolekcije = ((IRawGraphClient)Client).ExecuteGetCypherResults<Kolekcija>(query).ToList();

            foreach(Kolekcija k in kolekcije)
            {
                k.proizvodi = GetProizvodiFromKolekcija(k.id);
            }

            return kolekcije;
        }

        public static Kolekcija AddKolekcija(Kolekcija k)
        {
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                k.id = (mId+1).ToString();
            }
            catch (Exception)
            {
                k.id = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("naziv", k.tema);
            queryDict.Add("opis", k.layout);
            queryDict.Add("tema", k.tema);
            queryDict.Add("layout", k.layout);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Kolekcija {id:'" + k.id 
                                                            + "', naziv:'" + k.naziv
                                                            + "', opis:'" + k.opis
                                                            + "', tema:'" + k.tema
                                                            + "', layout:'" + k.layout
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Kolekcija> kolekcije = ((IRawGraphClient)client).ExecuteGetCypherResults<Kolekcija>(query).ToList();

            for (int i = 0; i < k.proizvodi.Count; i++)
            {
                if(k.proizvodi[i]!=null)
                {
                    Proizvod p = k.proizvodi[i];
                    if (p.id == null)
                        p = AddProizvod(p);
                    AddProizvodKolekcijaRelationship(k.id, p.id);
                }
            }
            
            return k;
        }

        public static void AddProizvodKolekcijaRelationship(string kol_id, string pro_id)
        {
            var queryyy = Client.Cypher
           .Match("(kol:Kolekcija)", "(pro:Proizvod)")
           .Where((Kolekcija kol) => kol.id == kol_id)
           .AndWhere((Proizvod pro) => pro.id == pro_id)
           .Create("(kol)-[:IMA]->(pro)");

            queryyy.ExecuteWithoutResults();
        }

        public static Kolekcija GetKolekcijaFromId(String id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Kolekcija {id:'" + id + "'}) RETURN n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            Kolekcija kk = ((IRawGraphClient)Client).ExecuteGetCypherResults<Kolekcija>(query).ToList().FirstOrDefault();
            if(kk!=null)
                kk.proizvodi = GetProizvodiFromKolekcija(id);

            return kk;
        }

        public static List<Proizvod> GetProizvodiFromKolekcija(String idKolekcije)
        {
            List<Proizvod> proizvodi =
                Client.Cypher
                    .Match("(p:Proizvod)<-[:IMA]-(k:Kolekcija{id:{id_param}})")
                    .WithParam("id_param", idKolekcije)
                    .Return(p => p.As<Proizvod>())
                    .Results.ToList();

            return proizvodi;
            
        }

        #endregion

        #region Katalog

        public static List<Katalog> dobaviSveKataloge()
        {

            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Katalog) RETURN n LIMIT 25",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Katalog> katalozi = ((IRawGraphClient)Client).ExecuteGetCypherResults<Katalog>(query).ToList();

            foreach(Katalog k in katalozi)
            {
                k.kolekcije = GetKolekcijeFromKatalog(k.id);
                k.proizvodi = GetProizvodiFromKatalog(k.id);
            }

            return katalozi;  
        }

        public static Katalog AddKatalog(Katalog k)
        {
            string maxId = getMaxId();

            try
            {
                int mId = Int32.Parse(maxId);
                k.id = (mId + 1).ToString();
            }
            catch (Exception)
            {
                k.id = "";
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("year", k.year);
            queryDict.Add("month", k.month);
            queryDict.Add("hashtag", k.hashtag);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Katalog {id:'" + k.id
                                                            + "', year:'" + k.year
                                                            + "', month:'" + k.month
                                                            + "', hashtag:'" + k.hashtag
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);

            List<Katalog> katalozi = ((IRawGraphClient)client).ExecuteGetCypherResults<Katalog>(query).ToList();

            for (int i = 0; i < k.kolekcije.Count; i++)
            {
                Kolekcija kol = k.kolekcije[i];
                if (kol.id == null)
                    kol = AddKolekcija(kol);
                AddKatalogKolekcijaRelationship(k.id, kol.id);
            }

            for (int i = 0; i < k.proizvodi.Count; i++)
            {
                if (k.proizvodi[i] != null)
                {
                    Proizvod p = k.proizvodi[i];
                    if (p.id == null)
                        p = AddProizvod(p);
                    AddKatalogProizvodRelationship(k.id, p.id);
                }
            }


            return k;
        }

        public static void AddKatalogKolekcijaRelationship(string kat_id, string kol_id)
        {
            var queryyy = Client.Cypher
           .Match("(kat:Katalog)", "(kol:Kolekcija)")
           .Where((Katalog kat) => kat.id == kat_id)
           .AndWhere((Kolekcija kol) => kol.id == kol_id)
           .Create("(kat)-[:SADRZI]->(kol)");

            queryyy.ExecuteWithoutResults();
        }

        public static void AddKatalogProizvodRelationship(string kat_id, string pro_id)
        {
            var queryyy = Client.Cypher
           .Match("(kat:Katalog)", "(pro:Proizvod)")
           .Where((Katalog kat) => kat.id == kat_id)
           .AndWhere((Proizvod pro) => pro.id == pro_id)
           .Create("(kat)-[:SADRZI]->(pro)"); /////////fali dodavanje atributa vezaaaa

            queryyy.ExecuteWithoutResults();
        }

        public static List<Proizvod> GetProizvodiFromKatalog(String idKataloga)
        {
            List<Proizvod> proizvodi =
                Client.Cypher
                    .Match("(p:Proizvod)<-[:SADRZI]-(k:Katalog{id:{id_param}})")
                    .WithParam("id_param", idKataloga)
                    .Return(p => p.As<Proizvod>())
                    .Results.ToList();

            return proizvodi;
        }

        public static List<Kolekcija> GetKolekcijeFromKatalog(String idKataloga)
        {
            List<Kolekcija> kolekcije =
                Client.Cypher
                    .Match("(kol:Kolekcija)<-[:SADRZI]-(k:Katalog{id:{id_param}})")
                    .WithParam("id_param", idKataloga)
                    .Return(kol => kol.As<Kolekcija>())
                    .Results.ToList();

            foreach(Kolekcija kol in kolekcije)
            {
                kol.proizvodi = GetProizvodiFromKolekcija(kol.id);
            }

            return kolekcije;
        }

        public static Katalog GetKatalogFromId(String id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Katalog {id:'" + id + "'}) RETURN n",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            Katalog kk = ((IRawGraphClient)Client).ExecuteGetCypherResults<Katalog>(query).ToList().FirstOrDefault();

            kk.kolekcije = GetKolekcijeFromKatalog(id);
            kk.proizvodi = GetProizvodiFromKatalog(id);

            return kk;
        }

        #endregion

        #region Korisnik

        public static void AddKorisnik(Korisnik k) //moze da vraca i listu kor.
        {
            string maxId = getMaxId();
            
            if (k.id == null) //dodatan uslov zbog test podataka
            {
                try
                {
                    int mId = Int32.Parse(maxId);
                    k.id = (mId+1).ToString();
                }
                catch (Exception)
                {
                    k.id = "";
                }
            }

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("ime", k.ime);
            queryDict.Add("korisnicko", k.korisnicko);
            queryDict.Add("password", k.password);
            queryDict.Add("prezime", k.prezime);

            var query = new Neo4jClient.Cypher.CypherQuery("CREATE (n:Korisnik {id:'" + k.id + "', ime:'" + k.ime
                                                            + "', korisnicko:'" + k.korisnicko + "', password:'" + k.password
                                                            + "', prezime:'" + k.prezime
                                                            + "'}) return n",
                                                            queryDict, CypherResultMode.Set);


            List<Korisnik> korisnici = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            //return korisnici;

        }

        public static Korisnik UserExists(String username, String pass)
        {
            Korisnik k = GetKorisnikPoKorImenu(username);
            if (k != null && k.password.Equals(pass))
                return k;
            else
                return null;
        }

        public static Korisnik GetKorisnikPoKorImenu(String korIme)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (n:Korisnik {korisnicko:'" + korIme + "'}) RETURN n LIMIT 1",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Korisnik> korisnici = ((IRawGraphClient)Client).ExecuteGetCypherResults<Korisnik>(query).ToList();

            if (korisnici.Count != 0)
                return korisnici[0];
            else
                return null;
        }

        public static void DeleteKorisnikPoUsernameu(string korIme)
        {

            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            queryDict.Add("korIme", korIme);

            var query = new Neo4jClient.Cypher.CypherQuery("start n=node(*) where (n:Korisnik) and exists(n.korisnicko) and n.korisnicko =~ {korIme} delete n",
                                                            queryDict, CypherResultMode.Projection);
        }

        public static Korisnik GetKorisnikFromId(String id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("MATCH (k:Korisnik {id:'" + id + "'}) RETURN k",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            Korisnik result = ((IRawGraphClient)Client).ExecuteGetCypherResults<Korisnik>(query).ToList().FirstOrDefault();

            return result;
        }

        #endregion

        #region Rating

        public static void AddRatingToProduct(Rating rating)
        {
            //proizvod i korisnik ovde vec postoje, a kreira se nova veza

            var queryyy = Client.Cypher
            .Match("(k: Korisnik)", "(p:Proizvod)")
            .Where((Korisnik k) => k.id == rating.korisnik.id)
            .AndWhere((Proizvod p) => p.id == rating.proizvod.id)
            .Create("(k)-[r: RATING {ocena:{ocenaa}, wish:{wishh}}]->(p)")
            .WithParam("ocenaa", rating.ocena)
            .WithParam("wishh", rating.wish);

            queryyy.ExecuteWithoutResults();

            //ako postoji izmena, zovemo update za prosecnu ocenu i wishlist:
            if (rating.ocena != null)
                UpdateProductAvgOcena(rating.proizvod.id);

            if (rating.wish != null)
                UpdateProductWishNo(rating.proizvod.id); //ovde ako postoji wish onda znaci da je dodat novi
        }

        public static void UpdateProductAvgOcena(string product_id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (p:Proizvod)<-[r:RATING]-(k:Korisnik) where p.id = '" + product_id + "'and exists (r.ocena) return r.ocena",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<String> ocene = ((IRawGraphClient)Client).ExecuteGetCypherResults<String>(query).ToList();

            int sum = 0;

            foreach(String s in ocene)
            {
                sum += Int32.Parse(s);
            }

            double newAvg = (ocene.Count != 0) ? (double)sum / ocene.Count : 0; //ako nema nijednu ocenu

            //update:

            var updatedProduct = Client.Cypher.Match("(p:Proizvod)")
            .Where((Proizvod p) => p.id == product_id)
            .Set("p.rating = {avg}")
            .WithParams(new { avg = newAvg})
            .Return(p => p.As<Proizvod>())
            .Results
            .Single();

        }

        public static void UpdateProductWishNo(string product_id)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (p:Proizvod)<-[r:RATING]-(k:Korisnik) where p.id = '" + product_id + "'and exists (r.wish) return r.wish",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<String> wishes = ((IRawGraphClient)Client).ExecuteGetCypherResults<String>(query).ToList();

            var updatedProduct = Client.Cypher.Match("(p:Proizvod)")
            .Where((Proizvod p) => p.id == product_id)
            .Set("p.wishes = {wishNo}")
            .WithParams(new { wishNo = wishes.Count })
            .Return(p => p.As<Proizvod>())
            .Results
            .Single();
        }

        public static Rating GetProductRating(string product_id, string user_id)
        {
            //zove se kad korisnik zeli da vidi detalje proizvoda, da bi video kako je on sam ocenio proizvod

            var results = Client.Cypher
                    .Match("(p:Proizvod)<-[r:RATING]-(k:Korisnik)")
                    .Where((Proizvod p) => p.id == product_id)
                    .AndWhere((Korisnik k) => k.id == user_id)
                    .Return(() => new
                    {
                        pro = Return.As<Proizvod>("p"),
                        kor = Return.As<Korisnik>("k"),
                        rat = Return.As<Rating>("r"),
                    }).Results;


            if (results.Count() != 0) //ima rezultata
            {
                var result = results.Single();

                Rating toret = result.rat;
                toret.korisnik = result.kor;
                toret.proizvod = result.pro;

                return toret;
            }
            return null;
        }

        public static void UpdateProductRating(Rating newRating)
        {
            //update
            //ako je ostao bar 1 parametar radi se update, u suprotnom se brise cela veza

            if (newRating.ocena == null && newRating.wish == null) 
            {
                //brise se veza - oba propertija su null
                var query = Client.Cypher
                .Match("(k: Korisnik)-[r:RATING]->(p:Proizvod)")
                .Where((Korisnik k) => k.id == newRating.korisnik.id)
                .AndWhere((Proizvod p) => p.id == newRating.proizvod.id)
                .Delete("r");

                query.ExecuteWithoutResults();
            }
            else
            {
                //vrsi se update preko set query-ja
                //izostavice property ako je null

                var query = Client.Cypher
                .Match("(k: Korisnik)-[r:RATING]->(p:Proizvod)")
                .Where((Korisnik k) => k.id == newRating.korisnik.id)
                .AndWhere((Proizvod p) => p.id == newRating.proizvod.id)
                .Set("r.ocena={ocenaa}, r.wish={wishh}")
                .WithParam("ocenaa", newRating.ocena)
                .WithParam("wishh", newRating.wish);

                query.ExecuteWithoutResults();
            }
            
            //postoji izmena, zovemo update za prosecnu ocenu i wishlist:
            UpdateProductAvgOcena(newRating.proizvod.id);
            UpdateProductWishNo(newRating.proizvod.id);
        }

        #endregion

        #region TestData

        public static void DeleteAllData()
        {
            Client.Cypher.Match("(kat:Katalog)")
                         .DetachDelete("kat")
                         .ExecuteWithoutResults();

            Client.Cypher.Match("(pro:Proizvod)")
                       .DetachDelete("pro")
                       .ExecuteWithoutResults();

            Client.Cypher.Match("(kat:Korisnik)")
                        .DetachDelete("kat")
                        .ExecuteWithoutResults();

            Client.Cypher.Match("(pro:Kolekcija)")
                      .DetachDelete("pro")
                      .ExecuteWithoutResults();
        }

        public static void InsertTestData()
        {
            Korisnik korisnik1 = new Korisnik("1", "Sava", "Savic", "sava123", "sava123");
            Korisnik korisnik2 = new Korisnik(null, "Pera", "Peric", "admin", "pera93");

            AddKorisnik(korisnik1);
            AddKorisnik(korisnik2);

            Proizvod proizvod1 = new Proizvod();
            proizvod1.id = null;
            proizvod1.name = "Sampon";
            proizvod1.type = "Kozmetika";
            proizvod1.cost = 200.0;
            proizvod1.proizvodjac = "Johnsons";
            proizvod1.opis = "Blagi sampon";
            proizvod1.rating = 0;
            proizvod1.wishes = 0;
            proizvod1.img = "1"; ///ovo cemo da podesimo kad dodamo slike za test proizvode

            Proizvod proizvod2 = new Proizvod();
            proizvod2.id = null;
            proizvod2.name = "Sapun";
            proizvod2.type = "Kozmetika";
            proizvod2.cost = 50.0;
            proizvod2.proizvodjac = "Dove";
            proizvod2.opis = "Sa mirisom jasmina";        
            proizvod2.rating = 0;
            proizvod2.wishes = 0;
            proizvod2.img = "3";

            Proizvod proizvod3 = new Proizvod();
            proizvod3.id = null;
            proizvod3.name = "Zenska jakna";
            proizvod3.type = "Odeca";
            proizvod3.cost = 6000.0;
            proizvod3.proizvodjac = "Waikiki";
            proizvod3.opis = "";
            proizvod3.rating = 0;
            proizvod3.wishes = 0;
            proizvod3.img = "2";

            Proizvod proizvod4 = new Proizvod();
            proizvod4.id = null;
            proizvod4.name = "Rukavice";
            proizvod4.type = "Dodaci garderobi";
            proizvod4.cost = 1000.0;
            proizvod4.proizvodjac = "H&M";
            proizvod4.opis = "Od prave vune";
            proizvod4.rating = 0;
            proizvod4.wishes = 0;
            proizvod4.img = "5";

            Proizvod proizvod5 = new Proizvod();
            proizvod5.id = null;
            proizvod5.name = "Zimska kapa";
            proizvod5.type = "Dodaci garderobi";
            proizvod5.cost = 1500.0;
            proizvod5.proizvodjac = "H&M";
            proizvod5.opis = "Od prave vune";
            proizvod5.rating = 0;
            proizvod5.wishes = 0;
            proizvod5.img = "6";

            AddProizvod(proizvod1);
            AddProizvod(proizvod2);
            AddProizvod(proizvod3);
            AddProizvod(proizvod4);
            AddProizvod(proizvod5);

            Kolekcija k1 = new Kolekcija();
            k1.naziv = "Winter collection";
            k1.opis = "Everything you need to keep you warm during cold season";
            k1.layout = 1;
            k1.tema = 1;
            k1.proizvodi = new List<Proizvod>();
            k1.proizvodi.Add(proizvod3);
            k1.proizvodi.Add(proizvod4);
            k1.proizvodi.Add(proizvod5);

            AddKolekcija(k1);

            Katalog kat = new Katalog();
            kat.hashtag = "winter";
            kat.month = 12;
            kat.year = 2019;
            kat.proizvodi = new List<Proizvod>();
            kat.proizvodi.Add(proizvod1);
            kat.proizvodi.Add(proizvod2);
            kat.kolekcije = new List<Kolekcija>();
            kat.kolekcije.Add(k1);

            AddKatalog(kat);

            Rating r1 = new Rating();
            r1.korisnik = korisnik1;
            r1.proizvod = proizvod1;
            r1.ocena = "5";

            Rating r2 = new Rating();
            r2.korisnik = korisnik2;
            r2.proizvod = proizvod3;
            r2.ocena = "4";
            r2.wish = "1";

            Rating r3 = new Rating();
            r3.korisnik = korisnik1;
            r3.proizvod = proizvod3;
            r3.ocena = "3";

            AddRatingToProduct(r1);
            AddRatingToProduct(r2);
            AddRatingToProduct(r3);

        }

        #endregion

    }

}
