namespace finals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btn_GetPlanet_Click(object sender, EventArgs e)
        {
            try
            {
                int PlanetID = Convert.ToInt32(txt_GetID.Text);
            Planet NewPlanet = await JSONHelper.GetPlanet(PlanetID);


            //printing all variables onto rich text box
            rtx_GetAllSpecies.Text = " ";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Planet Name: " + NewPlanet.name;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Rotation Period: " + NewPlanet.rotation_period;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Orbital Period: " + NewPlanet.orbital_period;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Diameter: " + NewPlanet.diameter;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Climate: " + NewPlanet.climate;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Gravity: " + NewPlanet.gravity;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Terrain: " + NewPlanet.terrain;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Surface Water: " + NewPlanet.surface_water;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Population: " + NewPlanet.population;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
        }
             catch (Exception)
            {
                if (txt_GetID.Text == "")
                    MessageBox.Show("please enter an ID");
                return;
            }
        }

        private async void btn_GetPerson_Click(object sender, EventArgs e)
        {
            try
            {
                int PersonID = Convert.ToInt32(txt_GetID.Text);
            Person NewPerson = await JSONHelper.GetPerson(PersonID);


            //printing all variables onto rich text box
            rtx_GetAllSpecies.Text = " ";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Character Name: " + NewPerson.name;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Height: " + NewPerson.height;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Mass: " + NewPerson.mass;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Skin Color: " + NewPerson.skin_color;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Hair Color: " + NewPerson.hair_color;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Eye Color: " + NewPerson.eye_color;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Birth Year: " + NewPerson.birth_year;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Gender: " + NewPerson.gender;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Homeworld: " + NewPerson.homeworld;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            foreach (var i in NewPerson.starships)
            {
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " " + i;
            }
        }
             catch (Exception)
            {
                if (txt_GetID.Text == "")
                    MessageBox.Show("please enter an ID");
                return;
            }

        }

        private async void btn_GetSpecies_Click(object sender, EventArgs e)
        {
            try
            {
                AllSpecies NewSpecies = await JSONHelper.GetAllSpecies();


            //printing all variables onto rich text box
            rtx_GetAllSpecies.Text = " ";
            foreach (var i in NewSpecies.results)
            {
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Species Name: " + i.name;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Classification: " + i.classification;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Designation: " + i.designation;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Average Height: " + i.average_height;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Skin Colors: " + i.skin_colors;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Hair Colors: " + i.hair_colors;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Eye Colors: " + i.eye_colors;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Average Lifespan: " + i.average_lifespan;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Homeworld: " + i.homeworld;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Language: " + i.language;
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " ";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
                rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " New Species: ";
            }
            }
            catch (Exception)
            {
                if (txt_GetID.Text == "")
                    MessageBox.Show("please enter an ID");
                return;
            }
        }

        private async void btn_GetStarship_Click(object sender, EventArgs e)
        {
            try
            {
                int StarshipID = Convert.ToInt32(txt_GetID.Text);
            Starships NewStarship = await JSONHelper.GetStarship(StarshipID);

            
            //printing all variables onto rich text box
            rtx_GetAllSpecies.Text = " ";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Starship Name: " + NewStarship.name;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Model: " + NewStarship.model;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Manufacturer: " + NewStarship.manufacturer;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Cos:t " + NewStarship.cost_in_credits;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Length: " + NewStarship.length;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Max Atmosphere Speed: " + NewStarship.max_atmosphering_speed;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Crew Coun:t " + NewStarship.crew;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Passanger Count: " + NewStarship.passengers;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Cargo Capacity: " + NewStarship.cargo_capacity;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Consumables: " + NewStarship.consumables;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Hyperdrive Rating: " + NewStarship.hyperdrive_rating;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "MGLT: " + NewStarship.MGLT;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + "Classification: " + NewStarship.starship_class;
            rtx_GetAllSpecies.Text = rtx_GetAllSpecies.Text + " \n";
        }
             catch (Exception)
            {
                if (txt_GetID.Text == "")
                    MessageBox.Show("please enter an ID");
                return;
            }
}

        //input validation, not allowing strings or decimals
        private void txt_GetID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow no decimal points
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > 0))
            {
                e.Handled = true;
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //calling the price/cargo space Ratio function
        //this function tells how much the cost of the ship is per cargo space
        private async void btn_Ratio_Click(object sender, EventArgs e)
        {
            int StarshipID = Convert.ToInt32(txt_GetID.Text);
            Starships NewStarship = await JSONHelper.GetStarship(StarshipID);
            string Ratiovary = Starships.CalculateLoad(NewStarship.cost_in_credits, NewStarship.cargo_capacity);
            txt_Ratio.Text = Ratiovary;
        }
//blank action
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}

  