

#region using statements

using DataAccessComponent.StoredProcedureManager.DeleteProcedures;
using DataAccessComponent.StoredProcedureManager.FetchProcedures;
using DataAccessComponent.StoredProcedureManager.InsertProcedures;
using DataAccessComponent.StoredProcedureManager.UpdateProcedures;
using ObjectLibrary.BusinessObjects;
using System;
using System.Data;
using System.Data.SqlClient;

#endregion


namespace DataAccessComponent.DataManager.Writers
{

    #region class MemberWriterBase
    /// <summary>
    /// This class is used for converting a 'Member' object to
    /// the SqlParameter[] to perform the CRUD methods.
    /// </summary>
    public class MemberWriterBase
    {

        #region Static Methods

            #region CreatePrimaryKeyParameter(Member member)
            /// <summary>
            /// This method creates the sql Parameter[] array
            /// that holds the primary key value.
            /// </summary>
            /// <param name='member'>The 'Member' to get the primary key of.</param>
            /// <returns>A SqlParameter[] array which contains the primary key value.
            /// to delete.</returns>
            internal static SqlParameter[] CreatePrimaryKeyParameter(Member member)
            {
                // Initial Value
                SqlParameter[] parameters = new SqlParameter[1];

                // verify user exists
                if (member != null)
                {
                    // Create PrimaryKey Parameter
                    SqlParameter @Id = new SqlParameter("@Id", member.Id);

                    // Set parameters[0] to @Id
                    parameters[0] = @Id;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateDeleteMemberStoredProcedure(Member member)
            /// <summary>
            /// This method creates an instance of an
            /// 'DeleteMember'StoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Member_Delete'.
            /// </summary>
            /// <param name="member">The 'Member' to Delete.</param>
            /// <returns>An instance of a 'DeleteMemberStoredProcedure' object.</returns>
            public static DeleteMemberStoredProcedure CreateDeleteMemberStoredProcedure(Member member)
            {
                // Initial Value
                DeleteMemberStoredProcedure deleteMemberStoredProcedure = new DeleteMemberStoredProcedure();

                // Now Create Parameters For The DeleteProc
                deleteMemberStoredProcedure.Parameters = CreatePrimaryKeyParameter(member);

                // return value
                return deleteMemberStoredProcedure;
            }
            #endregion

            #region CreateFindMemberStoredProcedure(Member member)
            /// <summary>
            /// This method creates an instance of a
            /// 'FindMemberStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Member_Find'.
            /// </summary>
            /// <param name="member">The 'Member' to use to
            /// get the primary key parameter.</param>
            /// <returns>An instance of an FetchUserStoredProcedure</returns>
            public static FindMemberStoredProcedure CreateFindMemberStoredProcedure(Member member)
            {
                // Initial Value
                FindMemberStoredProcedure findMemberStoredProcedure = null;

                // verify member exists
                if(member != null)
                {
                    // Instanciate findMemberStoredProcedure
                    findMemberStoredProcedure = new FindMemberStoredProcedure();

                    // Now create parameters for this procedure
                    findMemberStoredProcedure.Parameters = CreatePrimaryKeyParameter(member);
                }

                // return value
                return findMemberStoredProcedure;
            }
            #endregion

            #region CreateInsertParameters(Member member)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// inserting a new member.
            /// </summary>
            /// <param name="member">The 'Member' to insert.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateInsertParameters(Member member)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[3];
                SqlParameter param = null;

                // verify memberexists
                if(member != null)
                {
                    // Create [Active] parameter
                    param = new SqlParameter("@Active", member.Active);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create [FirstName] parameter
                    param = new SqlParameter("@FirstName", member.FirstName);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create [LastName] parameter
                    param = new SqlParameter("@LastName", member.LastName);

                    // set parameters[2]
                    parameters[2] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateInsertMemberStoredProcedure(Member member)
            /// <summary>
            /// This method creates an instance of an
            /// 'InsertMemberStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Member_Insert'.
            /// </summary>
            /// <param name="member"The 'Member' object to insert</param>
            /// <returns>An instance of a 'InsertMemberStoredProcedure' object.</returns>
            public static InsertMemberStoredProcedure CreateInsertMemberStoredProcedure(Member member)
            {
                // Initial Value
                InsertMemberStoredProcedure insertMemberStoredProcedure = null;

                // verify member exists
                if(member != null)
                {
                    // Instanciate insertMemberStoredProcedure
                    insertMemberStoredProcedure = new InsertMemberStoredProcedure();

                    // Now create parameters for this procedure
                    insertMemberStoredProcedure.Parameters = CreateInsertParameters(member);
                }

                // return value
                return insertMemberStoredProcedure;
            }
            #endregion

            #region CreateUpdateParameters(Member member)
            /// <summary>
            /// This method creates the sql Parameters[] needed for
            /// update an existing member.
            /// </summary>
            /// <param name="member">The 'Member' to update.</param>
            /// <returns></returns>
            internal static SqlParameter[] CreateUpdateParameters(Member member)
            {
                // Initial Values
                SqlParameter[] parameters = new SqlParameter[4];
                SqlParameter param = null;

                // verify memberexists
                if(member != null)
                {
                    // Create parameter for [Active]
                    param = new SqlParameter("@Active", member.Active);

                    // set parameters[0]
                    parameters[0] = param;

                    // Create parameter for [FirstName]
                    param = new SqlParameter("@FirstName", member.FirstName);

                    // set parameters[1]
                    parameters[1] = param;

                    // Create parameter for [LastName]
                    param = new SqlParameter("@LastName", member.LastName);

                    // set parameters[2]
                    parameters[2] = param;

                    // Create parameter for [Id]
                    param = new SqlParameter("@Id", member.Id);
                    parameters[3] = param;
                }

                // return value
                return parameters;
            }
            #endregion

            #region CreateUpdateMemberStoredProcedure(Member member)
            /// <summary>
            /// This method creates an instance of an
            /// 'UpdateMemberStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Member_Update'.
            /// </summary>
            /// <param name="member"The 'Member' object to update</param>
            /// <returns>An instance of a 'UpdateMemberStoredProcedure</returns>
            public static UpdateMemberStoredProcedure CreateUpdateMemberStoredProcedure(Member member)
            {
                // Initial Value
                UpdateMemberStoredProcedure updateMemberStoredProcedure = null;

                // verify member exists
                if(member != null)
                {
                    // Instanciate updateMemberStoredProcedure
                    updateMemberStoredProcedure = new UpdateMemberStoredProcedure();

                    // Now create parameters for this procedure
                    updateMemberStoredProcedure.Parameters = CreateUpdateParameters(member);
                }

                // return value
                return updateMemberStoredProcedure;
            }
            #endregion

            #region CreateFetchAllMembersStoredProcedure(Member member)
            /// <summary>
            /// This method creates an instance of a
            /// 'FetchAllMembersStoredProcedure' object and
            /// creates the sql parameter[] array needed
            /// to execute the procedure 'Member_FetchAll'.
            /// </summary>
            /// <returns>An instance of a(n) 'FetchAllMembersStoredProcedure' object.</returns>
            public static FetchAllMembersStoredProcedure CreateFetchAllMembersStoredProcedure(Member member)
            {
                // Initial value
                FetchAllMembersStoredProcedure fetchAllMembersStoredProcedure = new FetchAllMembersStoredProcedure();

                // return value
                return fetchAllMembersStoredProcedure;
            }
            #endregion

        #endregion

    }
    #endregion

}
