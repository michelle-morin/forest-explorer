### Friday, May 8th

* 7:30am - create subdirectory (client) for React front-end using create-react-app

* 8:10am - finished adding initial structure to README (description, tech used, specifications, setup/install)

* 9:05am - finished re-writing project proposal

* 10am - finished making base map with React-Leaflet, shifting to tutorials/codealongs next to learn more about adding geojson features

* 10:30am - successfully displayed geojson features on map! Now, beginning the process of making each feature interactive.

* 12:15pm - successfully changed color of selected trail segment on mouse click, but need to implement method to remove the selected color from previously-clicked trails (to only have a different color for the currently clicked trail).

* 1:45pm - have been switching between using a functional component with state hooks and using a class component to change colors of selected trail. still unable to deselect previous trail.

* 2:55pm - spent the past hour scouring stackoverflow and google for solutions to the color issue I'm experiencing. still troubleshooting.

* 3:20pm - have not resolved color changing issue, but shifting gears to start working on a wireframe and component tree for the frontend.

* 3:48pm - added component tree to readme;

* 4:15 - implemented mouseover/mouseout color changes for trails, but color change on click now reverts to default style on mouseout :(

* 4:45 - updated prose in proposal and touched up readme

* 4:50pm - current state of the trail exploration page (TrailMap component). This is a static shot; the map is a slippy map with pan/zoom:
![trail map](/planning/progress-photo.png)

### Friday, May 15th

* 8:00am-9:30am - refactored RoutePlanner component to dynamically display route details, add trail button, and delete route button. Finished requirements of MVP.

* 9:30am-11:40am - researched various ways to display elevation details for a route, including using [this microservice](https://github.com/perliedman/elevation-service) to populate my existing geojson data with elevation data (did not succeed after several attempts of using this service).

* 11:40am-12:10pm - create different routes using react router and add navigation and splash page components.

* 12:40pm-3pm - researched component libraries, worked on styling, creating styled components, and updating some existing components with react-bootstrap components.