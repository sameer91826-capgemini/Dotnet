using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capgemini.PolicyEndorsement.Entities;
using Capgemini.PolicyEndorsement.Exceptions;
using System.Reflection;
using System.Data.Entity.Core.Objects;

namespace Capgemini.PolicyEndorsement.DataAccessLayer
{
    public class PolicyDAL
    {
        PolicyEntities entities = new PolicyEntities();
        DataTable dt;

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties by using reflection   
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names  
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {

                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
        public DataTable GetAllEndorsementDAL()
        {
            ObjectResult<prcEndorsementDetails_Result> dr = entities.prcEndorsementDetails();
            List<prcEndorsementDetails_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }      
        public string CustIDGenDAL(string policyId)
        {
            string result = entities.prccustIDGen(policyId).FirstOrDefault();
            return result;
        }

        public DataTable GetAllEndorsementCustDAL(string custnum)
        {
            ObjectResult<prcEndorsementDetailsCust_Result> dr = entities.prcEndorsementDetailsCust(custnum);
            List<prcEndorsementDetailsCust_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }
        public DataTable GetAllTransactionIDDAL(string custnum)
        {
            ObjectResult<prcTransactionDetailsID_Result> dr = entities.prcTransactionDetailsID(custnum);
            List<prcTransactionDetailsID_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }

        public DataTable GetAllTransactionDAL()
        {
            ObjectResult<prcTransDetails_Result> dr = entities.prcTransDetails();
            List<prcTransDetails_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }


        public bool AddTransactionDAL(Transaction transaction)
        {
            bool recordAdded = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcTransactionDetails @policyID,@transactionID,@statusID,@insuredName,@insuredAge,@dob,@gender,@nominee,@relation,@smoker,@address,@telephone,@premiumFrequency,@currentStatus",
               new SqlParameter("@policyID", transaction.PolicyID),
               new SqlParameter("@transactionID", transaction.TransactionID),
               new SqlParameter("@statusID", transaction.StatusID),
               new SqlParameter("@insuredName", transaction.InsuredName),
               new SqlParameter("@insuredAge", transaction.InsuredAge),
               new SqlParameter("@dob", transaction.Dob),
               new SqlParameter("@gender", transaction.Gender),
               new SqlParameter("@nominee", transaction.Nominee),
               new SqlParameter("@relation", transaction.Relation),
               new SqlParameter("@smoker", transaction.Smoker),
               new SqlParameter("@address", transaction.Address),
               new SqlParameter("@telephone", transaction.Telephone),
               new SqlParameter("@premiumFrequency", transaction.PremiumFrequency),
               new SqlParameter("@currentStatus", transaction.CurrentStatus));
                recordAdded = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordAdded;
        }


        public bool UpdateCustomersDAL(Customer customer)
        {
            bool recordupdated = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcCustomerUpdate @customernumber,@dob,@gender,@smoker,@address,@telephone",
               new SqlParameter("@customernumber", customer.CustomerNumber),
               new SqlParameter("@dob", customer.Dob),
               new SqlParameter("@gender", customer.Gender),
               new SqlParameter("@smoker", customer.Smoker),
               new SqlParameter("@address", customer.Address),
               new SqlParameter("@telephone", customer.Telephone));
                recordupdated = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordupdated;
        }

        public bool UpdatePolicyDAL(Policy policy)
        {
            bool recordupdated = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcEndorsementUpdateDetails @policyID,@insuredName,@insuredAge,@nominee,@relation,@premiumFrequency",
                new SqlParameter("@policyID", policy.PolicyID),
                new SqlParameter("@insuredName", policy.InsuredName),
                new SqlParameter("@insuredAge", policy.InsuredAge),
                new SqlParameter("@nominee", policy.Nominee),
                new SqlParameter("@relation", policy.Relation),
                new SqlParameter("@premiumFrequency", policy.PremiumFrequency));
                recordupdated = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordupdated;
        }
        public bool UpdateEndorsementstatusDAL(int id, string status)
        {
            bool recordupdated = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcStatusUpdateddd @transactionID,@currentstatus",
                new SqlParameter("@transactionID", id),
                new SqlParameter("@currentstatus", status));
                recordupdated = true;

            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordupdated;
        }
        public DataTable LoginDetailsDAL(string username, string password)
        {
            ObjectResult<prcLoginDetails_Result> dr = entities.prcLoginDetails(username, password);
            List<prcLoginDetails_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }

        public bool UpdateEndorsementDAL(Endorsement endorsement)
        {
            bool recordupdated = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcEndorsementUpdateDetails @policyID,@insuredName,@insuredAge,@dob,@gender,@nominee,@relation,@smoker,@address,@telephone,@premiumFrequency",
                new SqlParameter("@policyID", endorsement.PolicyID),
                new SqlParameter("@insuredName", endorsement.InsuredName),
                new SqlParameter("@insuredAge", endorsement.InsuredAge),
                new SqlParameter("@dob", endorsement.Dob),
                new SqlParameter("@gender", endorsement.Gender),
                new SqlParameter("@nominee", endorsement.Nominee),
                new SqlParameter("@relation", endorsement.Relation),
                new SqlParameter("@smoker", endorsement.Smoker),
                new SqlParameter("@address", endorsement.Address),
                new SqlParameter("@telephone", endorsement.Telephone),
                new SqlParameter("@premiumFrequency", endorsement.PremiumFrequency));
                recordupdated = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordupdated;
        }
        public DataTable GetAllEndorsementPolicyIDDAL(string policyID)
        {
            ObjectResult<prcEndorsementPolicyIDDetails_Result> dr = entities.prcEndorsementPolicyIDDetails(policyID);
            List<prcEndorsementPolicyIDDetails_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }


        public bool AddEndorsementDAL(Endorsement endorsement)
        {
            bool recordAdded = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcEndorsementInsert @policyID,@productType,@productName,@insuredName,@insuredAge,@dob,@gender,@nominee,@relation,@smoker,@address,@telephone,@premiumFrequency",
                new SqlParameter("@policyID", endorsement.PolicyID),
                new SqlParameter("@productType", endorsement.ProductType),
                new SqlParameter("@productName", endorsement.ProductName),
                new SqlParameter("@insuredName", endorsement.InsuredName),
                new SqlParameter("@insuredAge", endorsement.InsuredAge),
                new SqlParameter("@dob", endorsement.Dob),
                new SqlParameter("@gender", endorsement.Gender),
                new SqlParameter("@nominee", endorsement.Nominee),
                new SqlParameter("@relation", endorsement.Relation),
                new SqlParameter("@smoker", endorsement.Smoker),
                new SqlParameter("@address", endorsement.Address),
                new SqlParameter("@telephone", endorsement.Telephone),
                new SqlParameter("@premiumFrequency", endorsement.PremiumFrequency));
                recordAdded = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return recordAdded;
        }

        public int LoginCheckDAL(string username, string pwd)
        {
            try
            {
                int RES = 0, result;
                ObjectParameter output = new ObjectParameter("RES", typeof(int));
                entities.prcLoginCheck(username, pwd, output);
                result = Convert.ToInt32(output.Value.ToString());
                return result;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DataTable SearchPolicyNameDAL(string custName, DateTime dob)
        {
            try
            {
                ObjectResult<prcPolicySearchName_Result> dr = entities.prcPolicySearchName(custName, dob);
                List<prcPolicySearchName_Result> lst = dr.ToList();
                DataTable dt = ToDataTable(lst);
                return dt;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public DataTable SearchPolicyCustDAL(string custID)
        {
            try
            {
                ObjectResult<prcPolicySearchCust_Result> dr = entities.prcPolicySearchCust(custID);
                List<prcPolicySearchCust_Result> lst = dr.ToList();
                DataTable dt = ToDataTable(lst);
                return dt;
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
        public DataTable SearchPolicyIDDAL(string policyID)
        {
            try
            {
                ObjectResult<prcPolicySearchID_Result> dr = entities.prcPolicySearchID(policyID);
                List<prcPolicySearchID_Result> lst = dr.ToList();
                DataTable dt = ToDataTable(lst);
                return dt;
            }
            catch (PolicyException ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public bool AddPolicyDAL(Policy policy)
        {
            bool policyAdded = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcPolicyInsert @customernumber,@productID,@insuredName,@insuredAge,@nominee,@relation,@premiumFrequency",
                new SqlParameter("@customernumber", policy.CustomerNumber),
                new SqlParameter("@productID", policy.ProductID),
                new SqlParameter("@insuredName", policy.InsuredName),
                new SqlParameter("@insuredAge", policy.InsuredAge),
                new SqlParameter("@nominee", policy.Nominee),
                new SqlParameter("@relation", policy.Relation),
                new SqlParameter("@premiumFrequency", policy.PremiumFrequency));
                policyAdded = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return policyAdded;
        }
        public bool AddCustomerDAL(Customer customer)
        {
            bool customerAdded = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcCustomerInsert @customerName,@address,@telephone,@gender,@dob,@smoker,@hobbies",
                new SqlParameter("@customerName", customer.CustomerName),
                new SqlParameter("@address", customer.Address),
                new SqlParameter("@telephone", customer.Telephone),
                new SqlParameter("@gender", customer.Gender),
                new SqlParameter("@dob", customer.Dob),
                new SqlParameter("@smoker", customer.Smoker),
                new SqlParameter("@hobbies", customer.Hobbies));
                customerAdded = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return customerAdded;
        }
        public DataTable GetAllCustomerDAL()
        {
            ObjectResult<prcCustomerDetails_Result> dr = entities.prcCustomerDetails();
            List<prcCustomerDetails_Result> lst = dr.ToList();
            DataTable dt = ToDataTable(lst);
            return dt;
        }
        public bool AddProductDAL(Product product)
        {
            bool productAdded = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcProductInsert @customerNumber,@productName,@productType",
                new SqlParameter("@customerNumber", product.CustomerNumber),
                new SqlParameter("@productName", product.ProductName),
                new SqlParameter("@productType", product.ProductType));
                productAdded = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return productAdded;
        }
        public bool LoginGenDAL(Login login)
        {
            bool loginGenerated = false;
            try
            {
                entities.Database.SqlQuery<PolicyEntities>("exec prcLoginGen @customerNumbe,@loginID,@password",
                new SqlParameter("@customerNumber", login.CustomerNumber),
                new SqlParameter("@loginID", login.LoginID),
                new SqlParameter("@password", login.Password));
                loginGenerated = true;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            return loginGenerated;
        }
    }
}
