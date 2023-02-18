using Model.Dtos;

namespace Model.Services
{
    public class PersonService
    {
        public List<Person> Select()
        {
            using (var context = new OnlineShopDbContex())
            {
                try
                {
                    var pepole = context.Person.ToList();
                    return pepole;
                }
                catch (Exception)
                {
                    throw;
                }
                finally {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Insert(Person person) { 
            using(var context = new OnlineShopDbContex())
            {
                try
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Delete(Person person)
        {
            using(var context = new OnlineShopDbContex())
            {
                try
                {
                    var people = context.Person.Where(p => p.Id == person.Id).First();
                    context.Person.Remove(people);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if(context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public void Update(Person person)
        {
            using(var context = new OnlineShopDbContex())
            {
                try
                {
                    var people = context.Person.Where(p => p.Id == person.Id).First();
                    people.FirstName = person.FirstName;
                    people.LastName = person.LastName;
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    context.Dispose();
                }
            }
        }

    }
}
