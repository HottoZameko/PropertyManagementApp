using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DataAccessLayer
    {
        static string ConnString = "Data Source = localhost; Initial Catalog = PropertyManagementDB; Integrated Security = true;";
        SqlConnection dbConn = new SqlConnection(ConnString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertAdmin(Administrator admin)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", admin.Name);
            dbComm.Parameters.AddWithValue("@Surname", admin.Surname);
            dbComm.Parameters.AddWithValue("@Email", admin.Email);
            dbComm.Parameters.AddWithValue("@Password", admin.Password);
            dbComm.Parameters.AddWithValue("@Status", admin.Status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return x;
        }
        public DataTable GetAdmin()
        {

            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);

            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int InsertPropertyType(PropertyType type)
        {
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertPropertType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeDescription", type.PropertyTypeDescription);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetPropertyType()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertProperty(Property property)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description", property.Description);
            dbComm.Parameters.AddWithValue("@Price", property.Price);
            dbComm.Parameters.AddWithValue("@Image", property.Image);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", property.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", property.Status);
            dbComm.Parameters.AddWithValue("@SurbubID", property.SuburbID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }
        public int UpdateProperty(Property property)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdateProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", property.PropertyID);
            dbComm.Parameters.AddWithValue("@Price", property.Price);
            dbComm.Parameters.AddWithValue("@PropertyTypeID", property.PropertyTypeID);
            dbComm.Parameters.AddWithValue("@Status", property.Status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }
        public int DeleteProperty(Property property)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_DeleteProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", property.PropertyID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }
        public DataTable GetProperty()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);

            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertProvince (Province province)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@ProvinceDescription", province.ProvinceDescription);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetProvince()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetProvince", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertCity(City city)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID", city.ProvinceID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetCity()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetCity", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertSuburb(Suburb suburb)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbDescription", suburb.SurbubDescription);
            dbComm.Parameters.AddWithValue("@PostalCode", suburb.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", suburb.CityID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetSuburb()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetSuburb", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertAgency(Agency agency)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SurbubID", agency.SurbubID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public int DeleteAgency(Agency agency)
        {
            if(dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_DeleteAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return i;
        }
        public DataTable GetAgency()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetAgency", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertAgent(Agent agent)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public int UpdateAgent(Agent agent)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdateAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);

            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }

        public int DeleteAgent(Agent agent)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_DeleteAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetAgent()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertTenant(Tenant tenant)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name", tenant.Name);
            dbComm.Parameters.AddWithValue("@Surname", tenant.Surname);
            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Password", tenant.Password);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public int UpdateTenant(Tenant tenant)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdateTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);

            dbComm.Parameters.AddWithValue("@Email", tenant.Email);
            dbComm.Parameters.AddWithValue("@Phone", tenant.Phone);
            dbComm.Parameters.AddWithValue("@Status", tenant.Status);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return i;
        }
        public int DeleteTenant(Tenant tenant)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_DeleteTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@TenantID", tenant.TenantID);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();
            return i;
        }
        public DataTable GetTenant()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetTenant", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertPropertyAgent(PropertyAgent propertyAgent)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public int UpdatePropertyAgent(PropertyAgent propertyAgent)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdatePropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", propertyAgent.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", propertyAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propertyAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propertyAgent.Date);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetPropertyAgent()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetPropertyAgent", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public int InsertRental(Rental rental)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_InsertRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", rental.PropertyAgentID);
            dbComm.Parameters.AddWithValue("@TenantID", rental.TenantID);
            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public int UpdateRental(Rental rental)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_UpdateRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@RentalID", rental.RentalID);

            dbComm.Parameters.AddWithValue("@StartDate", rental.StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", rental.EndDate);

            int i = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return i;
        }
        public DataTable GetRental()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_GetRental", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable GetRentalsByPrice(PriceSearch p)
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_RentalsByPrice", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Price", p.price);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }
        public DataTable EndedRentals()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_EndedRentals", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable GetPropertyTypeAndProperty()
        {
            if (dbConn.State == ConnectionState.Closed)
            {
                dbConn.Open();
            }

            dbComm = new SqlCommand("sp_PropertyTypeAndProperty", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

    }
}
