using ExoLinq.Context;

namespace ExoLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            #region Exo 2_1
            /* Ecrire une requête pour présenter, pour chaque étudiant, 
                * le nom de l’étudiant, la date de naissance, le login et le résultat 
                * pour l’année de l’ensemble des étudiants. */
            //var result2_1 = dataContext.Students
            //    .Select(st => new { st.Last_Name, st.BirthDate, st.Login, st.Year_Result });

            //foreach (var item in result2_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 2_2
            /* Ecrire une requête pour présenter, pour chaque étudiant, 
             * son nom complet (nom et prénom séparés par un espace), son id et 
             * sa date de naissance. */
            //var result2_2 = dataContext.Students
            //    .Select(st => new { NomComplet = $"{st.Last_Name} {st.First_Name}", st.Student_ID, st.BirthDate });

            //foreach (var item in result2_2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 2_3
            /* Ecrire une requête pour présenter, pour chaque étudiant, 
             * dans une seule chaine de caractère l’ensemble des données relatives à 
             * un étudiant séparées par le symbole |. */
            //IEnumerable<string> result2_3 = dataContext.Students
            //    .Select(st => $"{st.Last_Name} | {st.First_Name} | {st.Section_ID} | {st.BirthDate} | {st.Student_ID} | {st.Year_Result} | {st.Course_ID}");

            //foreach (string item in result2_3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_1
            /* Pour chaque étudiant né avant 1955, donner le nom, le résultat annuel et le statut.
             * Le statut prend la valeur « OK » si l’étudiant à obtenu au moins 12 comme résultat 
             * annuel et « KO » dans le cas contraire. */
            //var result3_1 = dataContext.Students
            //    .Where(st => st.BirthDate.Year < 1955)
            //    .Select(st => new { st.Last_Name, st.Year_Result, Statut = (st.Year_Result) < 12 ? "KO": "OK" });

            //foreach (var item in result3_1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_2
            /* Donner pour chaque étudiant entre 1955 et 1965 le nom, le résultat annuel 
             * et la catégorie à laquelle il appartient. La catégorie est fonction du résultat 
             * annuel obtenu ; un résultat inférieur à 10 appartient à la catégorie « inférieure »,
             * un résultat égal à 10 appartient à la catégorie « neutre », un résultat autre 
             * appartient à la catégorie « supérieure ». */
            //var result3_2 = dataContext.Students
            //    .Where(st => st.BirthDate.Year >= 1955 && st.BirthDate.Year <= 1965)
            //    .Select(st => new { st.Last_Name, st.Year_Result, Categorie = (st.Year_Result) < 10 ? "Inférieur" : (st.Year_Result > 10) ? "Supérieur" : "Neutre" });

            //foreach (var item in result3_2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_3
            /* Ecrire une requête pour présenter le nom, l’id de section et de tous 
             * les étudiants qui ont un nom de famille qui termine par r. */
            //var result3_3 = dataContext.Students
            //    .Where(st => st.Last_Name?.EndsWith("r") ?? false)
            //    .Select(st => new { st.Last_Name, st.Section_ID });

            //foreach (var item in result3_3)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_4
            /* Ecrire une requête pour présenter le nom et le résultat annuel classé 
             * par résultats annuels décroissant de tous les étudiants qui ont obtenu 
             * un résultat annuel inférieur ou égal à 3 */
            //var result3_4 = dataContext.Students
            //    .Where(st => st.Year_Result <= 3)
            //    .OrderByDescending(st => st.Year_Result)
            //    .Select(st => new { st.Last_Name, st.Year_Result });

            //foreach (var item in result3_4)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_5
            /* Ecrire une requête pour présenter le nom complet (nom et prénom séparés par un espace) 
             * et le résultat annuel classé par nom croissant sur le nom de tous les 
             * étudiants appartenant à la section 1110 */
            //var result3_5 = dataContext.Students
            //    .Where(st => st.Section_ID == 1110)
            //    .OrderBy(st => st.Last_Name)
            //    .Select(st => new { NomComplet = $"{st.Last_Name} {st.First_Name}", st.Year_Result });

            //foreach (var item in result3_5)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_6
            /* Ecrire une requête pour présenter le nom, l’id de section et le 
             * résultat annuel classé par ordre croissant sur la section et décroissant
             * de l'id de tous les étudiants appartenant aux sections 1010 et 1020 ayant un 
             * résultat annuel qui n’est pas compris entre 12 et 18 */
            //var result3_6 = dataContext.Students
            //    .Where(st => new int[] { 1010, 1020 }.Contains(st.Section_ID) &&
            //        !(st.Year_Result >= 12 && st.Year_Result <= 18))
            //    .OrderBy(st => st.Section_ID)
            //    .ThenByDescending(st => st.Student_ID)
            //    .Select(st => new { st.Last_Name, st.Section_ID, st.Year_Result });

            //foreach (var item in result3_6)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 3_7
            /* Ecrire une requête pour présenter le nom, l’id de section et le résultat annuel 
             * sur 100 (nommer la colonne ‘result_100’) classé par ordre décroissant du résultat
             * de tous les étudiants appartenant aux sections commençant par 13 et ayant un 
             * résultat annuel sur 100 inférieur ou égal à 60. */
            //var result3_7 = dataContext.Students
            //    .Where(st => st.Section_ID.ToString().StartsWith("13") && st.Year_Result * 5 <= 60)
            //    .Select(st => new { st.Last_Name, st.Section_ID, Result100 = st.Year_Result * 5 })
            //    .OrderByDescending(st => st.Result100);

            //foreach (var item in result3_7)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Exo 4_1
            /* Donner le résultat annuel moyen pour l’ensemble des étudiants. */
            //double result4_1 = dataContext.Students.Average(st => st.Year_Result);
            //Console.WriteLine(result4_1);
            #endregion

            #region Exo 4_2
            /* Donner le plus haut résultat annuel obtenu par un étudiant. */
            //int result4_2 = dataContext.Students.Max(st => st.Year_Result);
            //Console.WriteLine(result4_2);


            #endregion

            #region Exo 4_3
            /* Donner la somme des résultats annuels. */
            //int result4_3 = dataContext.Students.Sum(st => st.Year_Result);
            //Console.WriteLine(result4_3);


            #endregion

            #region Exo 4_4
            /* Donner le résultat annuel le plus faible. */
            //var result4_4 = dataContext.Students.Min(st => st.Year_Result);
            //Console.WriteLine(result4_4);
            #endregion

            #region Exo 4_5
            /* Donner le nombre de lignes qui composent la séquence « Students » 
             * ayant obtenu un résultat annuel impair */
            //var result4_5 = dataContext.Students.Count(st => st.Year_Result % 2 == 1);
            //Console.WriteLine(result4_5);
            #endregion
        }
    }
}