using Asp.Net_Framework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Asp.Net_Framework.Controllers
{
    public class ContactController : ApiController
    {
        Contact[] contacts = new Contact[]
        {
            new Contact() { Id=0, firstName="Mayank", lastName="Srivastava"},
            new Contact() { Id=1, firstName="Shamya", lastName="Sharma"},
            new Contact() { Id=2, firstName="Meet", lastName="Kaur"}
        };

        // GET: api/Contact
        public IEnumerable<Contact> Get()
        {
            return contacts;

        }


        // GET: api/Contact/5
        public IHttpActionResult Get(int id)
        {
            Contact contact = contacts.FirstOrDefault<Contact>(c => c.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);

        }

        // POST: api/Contact
        public IEnumerable<Contact> Post([FromBody] Contact newContact)
        {
            List<Contact> contactsList = contacts.ToList<Contact>();
            newContact.Id = contactsList.Count;
            contactsList.Add(newContact);
            contacts = contactsList.ToArray();

            return contacts;


        }

        // PUT: api/Contact/5
        public IEnumerable<Contact> Put(int id, [FromBody] Contact updateContact)
        {
            Contact contact = contacts.FirstOrDefault<Contact>(c=>c.Id==id);
            if(contact != null)
            {
                contact.firstName = updateContact.firstName;
                contact.lastName = updateContact.lastName;

            }
           

            return contacts;
        }

        // DELETE: api/Contact/5
        public IEnumerable<Contact> Delete(int id)
        {
            
            contacts = contacts.Where<Contact>(c => c.Id !=id).ToArray<Contact>();



            return contacts;
        }
    }
}
