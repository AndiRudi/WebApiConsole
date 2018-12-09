# WebApiConsole
Owin Selfhost with mono and docker

The idea was to have a owin self hosted web api and a sql server which can be build/run using macos

To run, open the solution in Visual Studio for mac and run it (this triggers the build). You can go to `http://localhost:5000` to test if it's working locally. After that, run `docker-compose up` to move it to a container and run it. Go to `http://localhost:5000` and see it running.
