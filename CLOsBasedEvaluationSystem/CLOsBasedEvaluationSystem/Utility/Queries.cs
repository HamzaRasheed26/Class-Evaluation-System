using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOsBasedEvaluationSystem.Utility
{
    public class Queries
    {
        public static DataTable queryLookUpValues(string category)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select Name from Lookup where Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryAddStudent(string firstName, string lastName, string contact, string email, string regNo, string status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@firstName, @lastName, @contact, @email, @regNo, @status)", con);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@contact", contact);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            cmd.Parameters.AddWithValue("@status", findLookUpId(status));
            cmd.ExecuteNonQuery();
        }

        public static void queryEditStudent(string id, string firstName, string lastName, string contact, string email, string regNo, string status)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @firstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @regNo, Status = @Status WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Contact", contact);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            cmd.Parameters.AddWithValue("@Status", findLookUpId(status));
            cmd.ExecuteNonQuery();
        }

        public static int findLookUpId(string name)
        {
            int id;

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Lookup where Name = @status", con);
            cmd.Parameters.AddWithValue("@status", name);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            id = (int)(dt.Rows[0][0]);

            return id;
        }

        public static int queryCountActiveStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Student WHERE Status =  (SELECT LookUpId FROM Lookup WHERE Name = 'Active')", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static int queryCountCLOs()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM Clo", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static DataTable querySelectAllStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, S.FirstName, S.LastName, S.Contact, S.Email, S.RegistrationNumber, L.Name AS Status FROM Student S JOIN Lookup L ON S.Status = L.LookupId;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable querySelectActiveStudents()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, S.FirstName, S.LastName, S.Contact, S.Email, S.RegistrationNumber, L.Name AS Status FROM Student S JOIN Lookup L ON S.Status = L.LookupId WHERE L.Name = 'Active';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryDeleteStudent(string id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE  id = @id;", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        public static DataTable queryActiveStudentsForAttendance(string status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, CONCAT(FirstName, ' ', LastName) AS Name, RegistrationNumber FROM Student WHERE Status =  (SELECT LookUpId FROM Lookup WHERE Name = @status)", con);
            cmd.Parameters.AddWithValue("@status", status);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryAttendanceDateExist(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Count(*) FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @day", con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@day", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static bool queryAddAttendanceDate(DateTime dateTime)
        {
            if( queryAttendanceDateExist(dateTime) == 0)
            {
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Insert into ClassAttendance values (@dateTime)", con);
                cmd.Parameters.AddWithValue("@dateTime", dateTime);
                cmd.ExecuteNonQuery();
                return true;
            }
            return false;
        }

        public static int queryGetAttendanceID(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @day", con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@day", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static void queryMarkAttendance(int id, int stID, int status)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@id, @stID, @status)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@stID", stID);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
        }

        public static DataTable queryAttendanceDates()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "  SELECT AttendanceDate FROM ClassAttendance";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryStudentAttendanceCountByStatus(int status, DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT COUNT(*) FROM StudentAttendance S JOIN ClassAttendance C ON S.AttendanceId=C.Id WHERE AttendanceStatus = @id AND YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @date";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", status);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@date", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static int queryGetAttdId(DateTime dateTime)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Id FROM ClassAttendance WHERE YEAR(AttendanceDate) = @year AND MONTH(AttendanceDate) = @month AND DAY(AttendanceDate) = @date";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@year", dateTime.Year);
            cmd.Parameters.AddWithValue("@month", dateTime.Month);
            cmd.Parameters.AddWithValue("@date", dateTime.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)(dt.Rows[0][0]);
        }

        public static DataTable queryGetStddIdsStatus(int id)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT StudentId, AttendanceStatus FROM StudentAttendance WHERE AttendanceId = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static string queryGetStatusName(int id)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT Name FROM Lookup WHERE LookupId = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt.Rows[0][0].ToString();
        }

        public static DataTable queryGetCLOs()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clo;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable queryGetCLO(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clo WHERE Id = @id;", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryAddCLO(DateTime created, string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Clo values (@name, @dateTime, @dateTime)", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dateTime", created);
            cmd.ExecuteNonQuery();
        }

        public static void queryUpadateCLO(int id, string name)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @name,  DateUpdated = @dateTime WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dateTime", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public static void queryUpdateTimeCLO(int id, DateTime update)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Clo SET DateUpdated = @dateTime WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@Id", id);
            cmd.Parameters.AddWithValue("@dateTime", update);
            cmd.ExecuteNonQuery();
        }

        public static void queryAddRubric(string details, int cloId)
        {
            int id = queryGetNextRubricID();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Rubric values (@id, @details, @cloId)", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@details", details);
            cmd.Parameters.AddWithValue("@cloId", cloId);
            cmd.ExecuteNonQuery();

            queryUpdateTimeCLO(cloId, DateTime.Now);
        }

        public static DataTable queryGetAllRubrics()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rubric;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable queryGetGoodRubrics()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Rubric R WHERE (SELECT COUNT(*) FROM RubricLevel WHERE R.Id = RubricId) > 1;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryGetNextRubricID()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT MAX(ID) FROM Rubric", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = (int)(dt.Rows[0][0]);
            id++;
            return id;
        }

        public static DataTable queryGetAllRubricLevels(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RubricLevel WHERE RubricId = @id ORDER BY MeasurementLevel DESC;", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static int queryGetloId_byRubricLevelID(int rubricID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT CloId FROM Rubric R WHERE R.Id = @id;", con);
            cmd.Parameters.AddWithValue("@id", rubricID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = (int)(dt.Rows[0][0]);
            return id;
        }

        public static int queryGetMAXRubricLevel(int rubricID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT CASE WHEN MAX(MeasurementLevel) IS NULL THEN 0 ELSE MAX(MeasurementLevel) END FROM RubricLevel WHERE RubricId = @id;", con);
            cmd.Parameters.AddWithValue("@id", rubricID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int id = (int)(dt.Rows[0][0]);
          
            return id;
        }

        public static int queryIsRubricLevelExist(int rubricID, int level)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @id AND MeasurementLevel = @level;", con);
            cmd.Parameters.AddWithValue("@id", rubricID);
            cmd.Parameters.AddWithValue("@level", level);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int count = (int)(dt.Rows[0][0]);

            return count;
        }

        public static void queryAddRubricLevel(int rid, string details, int level, int cloId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO RubricLevel VALUES (@id, @description, @level)", con);
            cmd.Parameters.AddWithValue("@id", rid);
            cmd.Parameters.AddWithValue("@description", details);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.ExecuteNonQuery();

            queryUpdateTimeCLO(cloId, DateTime.Now);
        }

        public static void queryUpdateRubricLevel(int rlevelid, string details, int level, int cloId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE RubricLevel SET Details = @description, MeasurementLevel = @level WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", rlevelid);
            cmd.Parameters.AddWithValue("@description", details);
            cmd.Parameters.AddWithValue("@level", level);
            cmd.ExecuteNonQuery();

            queryUpdateTimeCLO(cloId, DateTime.Now);
        }

        public static void queryUpdateRubricName(int id, string Details,int cloId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Rubric SET Details = @Details WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Details", Details);
            cmd.ExecuteNonQuery();

            queryUpdateTimeCLO(cloId, DateTime.Now);
        }

        public static DataTable queryGetAllAssessments()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Assessment;", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryAddAssessment(string title, int marks, int weightage)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO Assessment VALUES (@title, @date, @marks, @weightage )", con);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@weightage", weightage);
            cmd.ExecuteNonQuery();

        }

        public static void queryUpdateAssessment(int id, string title, int marks, int weightage)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE Assessment SET Title = @title, TotalMarks = @marks, TotalWeightage = @weightage WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@marks", marks);
            cmd.Parameters.AddWithValue("@weightage", weightage);
            cmd.ExecuteNonQuery();
        }

        public static int queryGetAsmpMarks(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT TotalMarks FROM Assessment WHERE Id = @id;", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)dt.Rows[0][0];
        }

        public static DataTable queryGetAsmpCmp(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM AssessmentComponent WHERE AssessmentId = @id;", con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryAddAsmtComp(string name, int rubricId, int totalMarks, int asmtId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO AssessmentComponent VALUES (@name, @rubricId, @marks, @created, @updated, @asmtId )", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@rubricId", rubricId);
            cmd.Parameters.AddWithValue("@marks", totalMarks);
            cmd.Parameters.AddWithValue("@created", DateTime.Now);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            cmd.Parameters.AddWithValue("@asmtId", asmtId);
            cmd.ExecuteNonQuery();
        }

        public static void queryUpdateAsmtComp(int id, string name, int rubricId, int totalMarks, int asmtId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE AssessmentComponent SET Name = @name, RubricId = @rubricId, TotalMarks = @marks, DateUpdated = @updated, AssessmentId = @asmtId WHERE Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@rubricId", rubricId);
            cmd.Parameters.AddWithValue("@marks", totalMarks);
            cmd.Parameters.AddWithValue("@updated", DateTime.Now);
            cmd.Parameters.AddWithValue("@asmtId", asmtId);
            cmd.ExecuteNonQuery();
        }

        public static DataTable queryGetAsmpCmpMarks(int asmtId, int marks)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT A.Id, SUM(AC.TotalMarks), A.TotalMarks FROM AssessmentComponent AC JOIN Assessment A ON AC.AssessmentId = A.Id WHERE A.Id = @id GROUP BY A.Id, A.TotalMarks HAVING SUM(AC.TotalMarks) + @marks > (SELECT TotalMarks FROM Assessment WHERE Id = @id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", asmtId);
            cmd.Parameters.AddWithValue("@marks", marks);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable queryGetAsmpCmpMarks(int asmtId)
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT A.Id, SUM(AC.TotalMarks), A.TotalMarks FROM AssessmentComponent AC JOIN Assessment A ON AC.AssessmentId = A.Id WHERE A.Id = @id GROUP BY A.Id, A.TotalMarks";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", asmtId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable selectGoodAsmt()
        {
            var con = Configuration.getInstance().getConnection();
            string query = "SELECT * FROM Assessment A WHERE TotalMarks = (SELECT SUM(TotalMarks) FROM AssessmentComponent WHERE A.Id = AssessmentId)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void queryAddStResult(int stId, int cmpId, int levelId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("INSERT INTO StudentResult VALUES (@stId, @cmpId, @levelId, @date)", con);
            cmd.Parameters.AddWithValue("@stId", stId);
            cmd.Parameters.AddWithValue("@cmpId", cmpId);
            cmd.Parameters.AddWithValue("@levelId", levelId);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public static void updateStResult(int stId, int cmpId, int levelId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("UPDATE StudentResult SET RubricMeasurementId = @levelId, EvaluationDate = @date WHERE StudentId = @stId AND AssessmentComponentId = @cmpId", con);
            cmd.Parameters.AddWithValue("@stId", stId);
            cmd.Parameters.AddWithValue("@cmpId", cmpId);
            cmd.Parameters.AddWithValue("@levelId", levelId);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

        public static void DELETEStResult(int stId, int amstId)
        {
            DataTable dt = queryGetAsmpCmp(amstId);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int cmpId = (int)dt.Rows[i][0];
                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM StudentResult  WHERE StudentId = @stId AND AssessmentComponentId = @cmpId", con);
                cmd.Parameters.AddWithValue("@stId", stId);
                cmd.Parameters.AddWithValue("@cmpId", cmpId);
                cmd.ExecuteNonQuery();
            }
        }

        public static int ISResultExist(int stdId, int asmtCmpId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentResult WHERE StudentId = @stdId AND AssessmentComponentId = @asmtCmpId;", con);
            cmd.Parameters.AddWithValue("@stdId", stdId);
            cmd.Parameters.AddWithValue("@asmtCmpId", asmtCmpId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return (int)dt.Rows[0][0];
        }

        public static DataTable assessmentResult(int id)
        {
            var con = Configuration.getInstance().getConnection();

            string query = "SELECT S.Id, S.RegistrationNumber, CONCAT(S.FirstName, ' ', S.LastName) AS Name," +
                           "SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) * AC.TotalMarks) ObtainedMarks, " +
                           "(CASE " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 = 100 THEN 'A+' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 90 THEN 'A' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 80 THEN 'A-' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 70 THEN 'B+' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 60 THEN 'B' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 50 THEN 'B-' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 40 THEN 'C+' " +
                           "WHEN SUM((CAST(RL.MeasurementLevel AS FLOAT) / CAST(RR.CMAX AS FLOAT)) *AC.TotalMarks )/ SUM(AC.TotalMarks) * 100 >= 30 THEN 'C' " +
                           "WHEN SUM(AC.TotalMarks) IS NULL THEN 'N/A' " +
                           "ELSE 'F' " +
                           "END) AS Grade " +
                           "FROM StudentResult SR " +
                           "JOIN AssessmentComponent AC " +
                           "ON AC.Id = SR.AssessmentComponentId " +
                           "JOIN Assessment A " +
                           "ON AC.AssessmentId = A.Id AND A.Id = @Id " +
                           "JOIN RubricLevel RL " +
                           "ON RL.Id = SR.RubricMeasurementId " +
                           "JOIN(SELECT MAX(RL.MeasurementLevel) AS CMAX, R.Id " +
                                "FROM Rubric R " +
                                "JOIN RubricLevel RL " +
                                "ON R.Id = RL.RubricId " +
                                "GROUP BY R.Id) RR " +
                           "ON RR.Id = RL.RubricId " +
                           "JOIN Student S " +
                           "ON SR.StudentId = S.Id " +
                           "WHERE S.Status = (SELECT LookupId FROM Lookup WHERE Name = 'Active') " +
                           "GROUP BY S.Id, S.RegistrationNumber, CONCAT(S.FirstName, ' ', S.LastName) ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Id", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable prevResult(int stdId, int asmtCmpId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentResult  WHERE StudentId = @stdId AND AssessmentComponentId = @asmtCmpId;", con);
            cmd.Parameters.AddWithValue("@stdId", stdId);
            cmd.Parameters.AddWithValue("@asmtCmpId", asmtCmpId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable GETAttd(int stdId, DateTime date)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT L.Name " +
                                            " FROM StudentAttendance SA"+
                                            " JOIN Lookup L"+
                                            " ON L.LookupId = SA.AttendanceStatus"+
                                            " JOIN ClassAttendance CA"+
                                            " ON CA.Id = SA.AttendanceId AND YEAR(CA.AttendanceDate) = @year AND MONTH(CA.AttendanceDate) = @month AND DAY(CA.AttendanceDate) = @day" +
                                            " WHERE SA.StudentId = @stdId; ", con);
            cmd.Parameters.AddWithValue("@stdId", stdId);
            cmd.Parameters.AddWithValue("@year", date.Year);
            cmd.Parameters.AddWithValue("@month", date.Month);
            cmd.Parameters.AddWithValue("@day", date.Day);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static bool isAsmtCmpExistInResult(int asmtCmpID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentResult WHERE AssessmentComponentId = @cmpID", con);
            cmd.Parameters.AddWithValue("@cmpID", asmtCmpID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if ((int)dt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static void deleteAsmtCmp(int cmpId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM AssessmentComponent WHERE Id = @cmpId", con);
            cmd.Parameters.AddWithValue("@cmpId", cmpId);
            cmd.ExecuteNonQuery();
        }

        public static bool isAsmtExistInCmp(int asmtID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AssessmentComponent WHERE AssessmentId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", asmtID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if ((int)dt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static void deleteAsmt(int Id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Assessment WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
        }

        public static bool isRubricExistInCmp(int rubricID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM AssessmentComponent WHERE RubricId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", rubricID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if ((int)dt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static bool isRubricExistInRubbricLevel(int rubricID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM RubricLevel WHERE RubricId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", rubricID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if ((int)dt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static void deleteRubric(int Id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Rubric WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
        }

        public static bool isCLOExistInRubric(int cloID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Rubric WHERE CloId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", cloID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if ((int)dt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static void deleteCLO(int Id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Clo WHERE Id = @Id", con);
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.ExecuteNonQuery();
        }

        public static void queryDeletePrevAttd(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM StudentAttendance WHERE AttendanceId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public static void queryDeleteAttdDate(int id)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM ClassAttendance WHERE Id = @ID", con);
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
        }

        public static bool isStdExistInResultAndAtd(int ID)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM StudentAttendance WHERE StudentId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable atdDt = new DataTable();
            da.Fill(atdDt);

            cmd = new SqlCommand("SELECT COUNT(*) FROM StudentResult WHERE StudentId = @ID", con);
            cmd.Parameters.AddWithValue("@ID", ID);
            da = new SqlDataAdapter(cmd);
            DataTable resultDt = new DataTable();
            da.Fill(resultDt);

            if ((int)atdDt.Rows[0][0] == 0 && (int)resultDt.Rows[0][0] == 0)
            {
                return true;
            }
            return false;
        }

        public static bool isRegNoExist(string regNo)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @regNo", con);
            cmd.Parameters.AddWithValue("@regNo", regNo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable atdDt = new DataTable();
            da.Fill(atdDt);

            if ((int)atdDt.Rows[0][0] == 0)
            {
                return false;
            }
            return true;
        }

        public static DataTable getCloResult(int stdId, int cloId)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT S.Id, S.RegistrationNumber, CONCAT(S.FirstName, ' ', S.LastName) AS Name ," +
                                                  " SUM(RL.MeasurementLevel/ RR.LMAX * AC.TotalMarks) AS CloMarks " +
                                            "FROM AssessmentComponent AC " +
                                            "JOIN RubriC R " +
                                            "ON R.Id = AC.RubricId " +
                                            "join Clo C " +
                                            "ON C.Id = R.CloId AND C.Id = @cloId " +
                                            "JOIN StudentResult SR " + 
                                            "ON SR.AssessmentComponentId = AC.Id " +
                                            "JOIN RubricLevel RL " +
                                            "ON RL.Id = SR.RubricMeasurementId " +
                                            "JOIN(SELECT MAX(RL.MeasurementLevel) AS LMAX, R.Id " +
                                                 "FROM Rubric R " +
                                                 "JOIN RubricLevel RL " +
                                                 "ON R.Id = RL.RubricId " +
                                                 "GROUP BY R.Id) RR " +
                                            "ON RR.Id = RL.RubricId " +
                                            "JOIN Student S " +
                                            "ON SR.StudentId = S.Id  AND S.Id = @stdId " +
                                            "GROUP BY S.Id, S.RegistrationNumber, CONCAT(S.FirstName, ' ', S.LastName) , C.Id", con);
            cmd.Parameters.AddWithValue("@stdId", stdId);
            cmd.Parameters.AddWithValue("@cloId", cloId);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable getCloTMarks()
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT C.Id, C.Name, " +
                                                "CASE " +
                                                "WHEN SUM(AC.TotalMarks) IS NULL THEN 0 " +
                                                "ELSE SUM(AC.TotalMarks) " +
                                                "END AS CloTMarks " +
                                            "FROM AssessmentComponent AC " +
                                            "JOIN RubriC R " +
                                            "ON R.Id = AC.RubricId " +
                                            "RIGHT JOIN Clo C " +
                                            "ON C.Id = R.CloId " +
                                            "GROUP BY  C.Id, C.Name", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}