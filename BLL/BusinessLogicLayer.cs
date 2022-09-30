using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        public int InsertAdmin(Administrator admin)
        {
            return dal.InsertAdmin(admin);
        }
        public DataTable GetAdmin()
        {
            return dal.GetAdmin();
        }
        public int InsertPropertyType(PropertyType type)
        {
            return dal.InsertPropertyType(type);
        }
        public DataTable GetPropertyType()
        {
            return dal.GetPropertyType();
        }
        public int InsertProperty(Property property)
        {
            return dal.InsertProperty(property);
        }
        public int UpdateProperty(Property property)
        {
            return dal.UpdateProperty(property);
        }
        public int DeleteProperty(Property property)
        {
            return dal.DeleteProperty(property);
        }
        public DataTable GetProperty()
        {
            return dal.GetProperty();
        }
        public int InsertProvince(Province province)
        {
            return dal.InsertProvince(province);
        }
        public DataTable GetProvince()
        {
            return dal.GetProvince();
        }
        public int InsertCity(City city)
        {
            return dal.InsertCity(city);
        }
        public DataTable GetCity()
        {
            return dal.GetCity();
        }
        public int InsertSuburb(Suburb suburb)
        {
            return dal.InsertSuburb(suburb);
        }
        public DataTable GetSuburb()
        {
            return dal.GetSuburb();
        }
        public int InsertAgency(Agency agency)
        {
            return dal.InsertAgency(agency);
        }
        public int DeleteAgency(Agency agency)
        {
            return dal.DeleteAgency(agency);
        }
        public DataTable GetAgency()
        {
            return dal.GetAgency();
        }
        public int InsertAgent(Agent agent)
        {
            return dal.InsertAgent(agent);
        }
        public int UpdateAgent(Agent agent)
        {
            return dal.UpdateAgent(agent);
        }
        public int DeleteAgent(Agent agent)
        {
            return dal.DeleteAgent(agent);
        }
        public DataTable GetAgent()
        {
            return dal.GetAgent();
        }
        public int InsertTenant(Tenant tenant)
        {
            return dal.InsertTenant(tenant);
        }
        public int UpdateTenant(Tenant tenant)
        {
            return dal.UpdateTenant(tenant);
        }
        public int DeleteTenant(Tenant tenant)
        {
            return dal.DeleteTenant(tenant);
        }
        public DataTable GetTenant()
        {
            return dal.GetTenant();
        }
        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {
            return dal.InsertPropertyAgent(propertyAgent);
        }
        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {
            return dal.UpdatePropertyAgent(propertyAgent);
        }
        public DataTable GetPropertyAgent()
        {
            return dal.GetPropertyAgent();
        }
        public int InsertRental(Rental rental)
        {
            return dal.InsertRental(rental);
        }
        public int UpdateRental(Rental rental)
        {
            return dal.UpdateRental(rental);
        }
        public DataTable GetRental()
        {
            return dal.GetRental();
        }
        public DataTable GetRentalsByPrice(PriceSearch p)
        {
            return dal.GetRentalsByPrice(p);
        }
        public DataTable EndedRentals()
        {
            return dal.EndedRentals();
        }
        public DataTable GetPropertyAndPropertyType()
        {
            return dal.GetPropertyTypeAndProperty();
        }
    }
}
