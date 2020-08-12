using System;
using System.Windows.Forms;

//c# moze byc pobrany na https://wearedevs.net/d/Exploit%20API
//upewnij sie zeby dodac odwołanie ja pobrane znowu
//to nizej jest bardzo wazne bez tego nie działa
using WeAreDevs_API;

//czit sam sie updajtuje
namespace Exploit_Template_with_WRDAPI
{
    public partial class cheat : Form
    {
        //Creates object so we can make calls to WeAreDevs_API.
        readonly ExploitAPI api = new ExploitAPI();
        /*To see methods you can call, go to 
        The project in the solution explorer -> References -> Right click on WeAreDevs_API.dll ->
        View in Object Browser -> WeAreDevs_API -> WeAreDevs_API -> click Exploit API.
        This will then show a list of all functions you can use!*/

        public cheat()
        {
            InitializeComponent();
        }

        //The exploit must be injected before calling any other function!
        private void BtnInject_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        //Executes the lua script
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            string script = inputScript.Text;
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            api.SendLimitedLuaScript(script);
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
        }

        //Sets your player's walkspeed to 100
        //Quick command button using a Lua script
        //szybko biegnisz
        private void BtnSpeed_Click(object sender, EventArgs e)
        {
#pragma warning disable CS0618 // Typ lub składowa jest przestarzała
            api.SendLimitedLuaScript("game.Players.LocalPlayer.Character.Humanoid.WalkSpeed=100");
#pragma warning restore CS0618 // Typ lub składowa jest przestarzała
        }

        //daje ci item btool
        //Quick command button using a pre-built command
        private void BtnBtools_Click(object sender, EventArgs e)
        {
            api.SendCommand("btools me");
        }

        //Example usage of a dynamic command
        //Quick command button using a pre-built command, but this one grab's the user input
        //Teleports the player to a player of the specified username
        private void BtnTPTo_Click(object sender, EventArgs e)
        {
            string username = inputTPTo.Text;
            api.SendCommand("teleport " + username);
        }

        //Changes UI text to say if the exploit is injected or not
        //Challenge: Try making the attach button only show if the exploit is not injected
        //mowi ci czy jest podłonczone do gry
        private void CheckInjected()
        {
            if (api.isAPIAttached())
            {
                //The exploit is injected and now ready to execute scripts/commands
                txtIsInjected.Text = "Is Injected: true";
            }
            else
            {
                //The exploit is not injected... The client must inject
                txtIsInjected.Text = "Is Injected: false";
            }
        }

        //Check if the exploit is injected on load
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //Check if the exploit is injected every 3 seconds
        // partzy co 3 sek czy jest podłonczone
        private void InjectedChecker_Tick(object sender, EventArgs e)
        {
            CheckInjected();
        }

        //wpisujesz tu skrypt kturu ma isc do gry
        private void inputScript_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsInjected_Click(object sender, EventArgs e)
        {

        }
    }
}
