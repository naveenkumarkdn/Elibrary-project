﻿using System; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //signup button to click event
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (checkMemberExists())
        {
            Response.Write("<script>alert('Member Already Exixsts with this member id');</script>");
        }
        else
        {
            signupNewMember();

        }
    }
    // user defined method
    bool checkMemberExists()
    {
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT * from member_master_tbl where member_id='" + TextBox8.Text.Trim() + "';", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            // con.Close();
            //Response.Write("<script>alert('sign upsucessful.GO to User Login');</script>");

            //trim function using front and back all the blank sequencess//
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
            return false;
        }

    }



    //userdefined method
    void signupNewMember()
    {

        //Response.Write("<script>alert('Testing');</script>");
        // Page.ClientScript.RegisterStartupScript(this.GetType(), "MyKey", "<script>alert('Testing');</script>", true);
        try
        {
            SqlConnection con = new SqlConnection(strcon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insert into member_master_tbl( full_name,dob,contact_no,email,state,city,pincode,full_address,member_id,password,account_status) values(@full_name,@dob,@contact_no,@email,@state,@city,@pincode,@full_address,@member_id,@password,@account_status)", con);
            cmd.Parameters.AddWithValue("@full_name", TextBox1.Text.Trim());
            cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
            cmd.Parameters.AddWithValue("@contact_no", TextBox3.Text.Trim());
            cmd.Parameters.AddWithValue("@email", TextBox4.Text.Trim());
            cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@city", TextBox6.Text.Trim());
            cmd.Parameters.AddWithValue("@pincode", TextBox7.Text.Trim());
            cmd.Parameters.AddWithValue("@full_address", TextBox5.Text.Trim());
            cmd.Parameters.AddWithValue("@member_id", TextBox8.Text.Trim());
            cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
            cmd.Parameters.AddWithValue("@account_status", "pending");
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('sign upsucessful.GO to User Login');</script>");

            //trim function using front and back all the blank sequencess//
        }
        catch (Exception ex)
        {
            Response.Write("<script>alert('" + ex.Message + "');</script>");
        }

    }
}