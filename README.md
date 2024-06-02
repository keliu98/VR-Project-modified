# csd3120-xr-tp
Team Members:
- THAM CHI SHENG GARY
- LIM YI QIN
- PANG TUN DAGH
- ANSON PANG WEI QIANG
- ANG JIN YANG
- LIU KE
- CHAN ZHENG YU

Team Project Assginment for CSD3120

## Installation

### Prerequisites
- Unity
- WebXR Export (Already been set up in the project) https://github.com/De-Panther/unity-webxr-export
- Git Bash https://gitforwindows.org/
- npm
- nodejs

### Importing the project
1. Install Unity. UnityHub will be installed automatically.
2. Open UnityHub and select the project folder to start importing the project.
3. The project will finish importing and will be ready to play.

### Running the Unity project
1. Under the "Project" tab, navigate to "Assets/Samples/WebXR Interactions/0.16.3-preview/Sample Scene/Scenes/"
2. Double click on the "Desert" Scene.

### Running the project on WebXR
1. Open the testfolder folder.
2. Right-click and select "Open Git Bash here".
3. Inside Git Bash command line:
	- Run **`npm install --global http-server`**.
	- Run the command **`openssl req -newkey rsa:2048 -new -nodes -x509 -days 3650 -keyout key.pem -out cert.pem`**. This command installs the cert.pem and key.pem files.
	- Run **`http-server -S -C cert.pem`**.
4. Once the http-server is set up, look for the 2 IP addresses under "Available on".
5. Run either of the 2 IP addresses on the Meta Quest browser.
6. Once you're done using the server, press CTRL-C to stop the server.

### Enabling WebRuntimeLocalhostAccess for Oculus Browser
1. Open the Oculus Browser on your Oculus Quest.
2. Type **`about:config`** into the address bar.
3. Press the "Enter" key on your controller to access the configuration settings.
4. Scroll down to the "WebRuntimeLocalhostAccess" setting and set it to "Enabled".
5. Restart the Oculus Browser for the changes to take effect.
