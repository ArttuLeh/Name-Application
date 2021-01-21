using System;
using System.Collections.Generic;

namespace Name_Application
{
    public partial class Index : System.Web.UI.Page
    {
        Names result = new Names();
        List<Names> lists = new List<Names>();
        IComparer<Names> compareAmount = new Names();
        IComparer<Names> compareNames = new SortByNames();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void getJson_Click(object sender, EventArgs e)
        {
            lists = result.GetJson();
            GridView1.DataSource = lists;
            GridView1.DataBind();
        }
        protected void orderByAmount_Click(object sender, EventArgs e)
        {
            lists = result.GetJson();
            lists.Sort(compareAmount);
            GridView1.DataSource = lists;
            GridView1.DataBind();
        }
        protected void alphabeticalOrder_Click(object sender, EventArgs e)
        {
            lists = result.GetJson();
            lists.Sort(compareNames);
            GridView1.DataSource = lists;
            GridView1.DataBind();
        }
        protected void totalAmount_Click(object sender, EventArgs e)
        {
            lists = result.GetJson();
            int sum = result.Sum(lists);
            totalAmount.Text = sum.ToString();
        }

        protected void search_Click(object sender, EventArgs e)
        {
            lists = result.GetJson();
            if (TextBox1.Text == "")
            {
                this.Label1.Text = "Fill the textbox!";
            }
            else if (!lists.Contains(lists.Find(x => x.name == char.ToUpper(TextBox1.Text[0]) + TextBox1.Text.Substring(1))))
            {
                this.Label1.Text = "The name didn't found!";
            }
            else
            {
                int find = lists.Find(x => x.name == char.ToUpper(TextBox1.Text[0]) + TextBox1.Text.Substring(1)).amount;
                this.Label1.Text = find.ToString();
            }
        }
    }
}