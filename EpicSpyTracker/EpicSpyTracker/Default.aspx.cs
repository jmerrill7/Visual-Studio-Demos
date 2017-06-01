using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicSpyTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] asset = new string[0];
                int[] elections = new int[0];
                int[] acts = new int[0];

                ViewState.Add("Asset", asset);
                ViewState.Add("Elections", elections);
                ViewState.Add("Acts", acts);
            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            string[] asset = (string[])ViewState["Asset"];
            int[] elections = (int[])ViewState["Elections"];
            int[] acts = (int[])ViewState["Acts"];

            Array.Resize(ref asset, asset.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref acts, acts.Length + 1);

            int newestItem = asset.GetUpperBound(0);

            asset[newestItem] = (assetNameTextBox.Text);
            elections[newestItem] = int.Parse(electionsTextBox.Text);
            acts[newestItem] = int.Parse(actsTextBox.Text);

            ViewState["Asset"] = asset;
            ViewState["Elections"] = elections;
            ViewState["Acts"] = acts;

            resultLabel.Text = String.Format("Last asset added: {0}<br />" +
                "Total amount of elections rigged: {1}<br />" +
                "Average acts of subterfuge per asset: {2:N}",
                asset[newestItem],
                elections.Sum(),
                acts.Average());
       }
    }
}