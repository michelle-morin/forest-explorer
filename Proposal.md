# Forest Explorer
## By: Michelle Morin

### Project Purpose: 
This application will allow users to familiarize themselves with trails in Forest Park, the network of trails along Portland’s northwest urban boundary. Users will be able to discover new trails and build hiking/running routes to explore the majesty of Forest Park. 

Many existing route planning tools require a user to select a starting point, draw a route, and select an ending point. This assumes familiarity with a region, and in my opinion, encourages people to continuously seek the familiar. In contrast, my application will allow both Forest Park enthusiasts and those without any knowledge of the city's trail system to intuitively explore details of various trail segments.

One of my main goals is to create a minimalist/modern user interface that mimics the serenity and calm of being within Forest Park’s tree canopy. I hope that this application empowers people to explore lower-trafficked and/or new-to-them portions of the trail network.

### MVP:

* The application includes a map of all trail segments in Forest Park.
* Each trail segment is selectable to view details about the trail, including the name, distance in miles, type of trail, and surface type.
* The application allows users to dynamically add trail segments to a route, as well as remove trail segments from the route.
* The application determines whether selected trail segments can be joined to form a route based on whether a selected segment adjoins another selected segment. 

### Implementing the MVP

* The frontend, written in JavaScript and JSX, will use React
* The backend, written in C#, will be a .NET web api with a seeded MySQL database
* The database will include at least one table (trails). Each entry in the trails table will hold data for a specific trail segment in forest park (e.g., distance in miles, type of trail, surface type, and connecting trails on either end of the segment).
* The frontend will make API calls to the backend, to obtain trail information for route planning.
* I seeded the database manually based on geojson data obtained from the [Portland OpenMaps Parks Trails API](https://gis-pdx.opendata.arcgis.com/datasets/parks-trails). This process began by wrangling a massive amount of data (every trail/path/greenway/shared corridor in Portland) into a dataset including only trail and road segments in Forest Park. The data obtained from the API included a name, surface type, trail type, and distance in miles for each trail segment, but did not include information for verifying routes/connecting trails, such as adjoining trail information. So, I created my own database schema including adjoining trail information (four potential connecting trails at each end of each trail segment) as well as trail details (name, surface type, type of trail, and distance in miles) for each trail entry.

### Stretch Goals

* implement user login/account functionality
  * I might use Identity to manage users, passwords, profile data, roles, claims, tokens, email confirmation, and more.
* incorporate the ability to store routes to a user account
  * This feature may require another database table for routes, as well as a join table to form a many-to-many relationship between trails and routes.
* incorporate the ability to determine the trailhead(s) closest to a route, and display details for that trailhead (e.g., geographical coordinates and parking availability).
  * This feature may require adding a trailheads table to the database. Alternatively, I may store each trailhead as an entry in the trails table with a “type” property of “trailhead”.
* render topographical data for forest park.
  * I would like to explore using the deckGL library for this feature.
* add versioning and swagger documentation to API
* add authentication/authorization to API, to only serve requests from the frontend client application

### Closing Thoughts

This is a passion project fueled by my love of trail running in Forest Park. I recognize that this application encourages additional trail use, which may adversely impact the trails and fragile ecosystems of our urban wilderness. Volunteer trail maintenance, or funding volunteer trail maintenance, is one way individuals can help lessen the impact of trail usage. While this project is in no way affiliated with the Forest Park Conservancy, their work in ecological conservation (removing invasive plants, repairing trails, etc.) and stewardship is worthy of recognition. Please visit their [website](https://forestparkconservancy.org/get-involved/) to learn more about volunteering and environmental advocacy opportunities.