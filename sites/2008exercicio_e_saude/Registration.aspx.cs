using System;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void txtSubmit_Click(object sender, EventArgs e)
    {
        string instrucaoSQL = @"INSERT into DM(country, institution, title, name, " +
                "address, city, zipcode, email, phone, fax, fee)" + 
                "VALUES ('" + "" + "','" + txtInstitution.Text + "','" 
                            + "" + "','" + txtName.Text + "','" 
                            + txtAddress.Text + "','" + txtCity.Text + "','" 
                            + txtZipCode.Text + "','" + txtEmail.Text + "','" 
                            + txtPhone.Text + "','" + txtFax.Text + "'," 
                            + Convert.ToInt16(rbFee.SelectedValue) + ")";

        ConnectionStringSettings conn = System.Configuration.ConfigurationManager.ConnectionStrings["SqlServerConnectionString"];
        string ligacao = conn.ConnectionString;
        SqlConnection conexao = new SqlConnection(ligacao);
        conexao.Open();

        SqlCommand comandoSQL = new SqlCommand(instrucaoSQL, conexao);

        try
        {
            comandoSQL.ExecuteNonQuery();
            //Enviar o email
            //MailMessage mm = new MailMessage(txtEmail.Text,ConfigurationManager.AppSettings.Get("MailFrom"));
            //mm.Subject = "Inscrição no Seminário em Desenvolvimento Motor da Criança";
            //mm.Body = "Todos os pagamentos deverão ser feitos para a conta 078101120112001184707. " +
            //"Todas as transferências deverão ter a identificação 'SDM'" +
            //", seguida do primeiro nome e apelido do titular. Validação da inscrição e emissão do recibo, "+
            //"depois de confirmado pela organização. O comprovativo da transferência, a enviar pelo inscrito " +
            //"para o fax nº 243 999292. Encargos com a transferência bancária são da responsabilidade " + 
            //"do inscrito.";
            //mm.IsBodyHtml = false;


            //SmtpClient smtp = new SmtpClient("mail.esdrm.pt",25);
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("sobreiro@esdrm.pt","vivaoporto");
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Send(mm);

            lblMsg.Text = "Obrigado pelo seu registo! <br />" +
                          "O registo só é válido depois da confirmação do pagamento.";
        }
        catch (Exception ex)
        {
            this.lblMsg.Text = ex.ToString();

        }
        conexao.Close();
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("index.html");
    }
    protected void rbFee_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
