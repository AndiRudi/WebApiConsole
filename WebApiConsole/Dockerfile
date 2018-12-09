FROM mono

COPY bin/Debug/ /app/  
VOLUME /app
WORKDIR /app

RUN ls -la ./

EXPOSE 5000

ENTRYPOINT [ "mono", "WebApiConsole.exe"]