# Vanilly

Just a sample application that combines

* an ASP.NET Core Server,
* an Angular Client,
* a Mongo DB and
* Authentication and Authorization

composed by `Docker Compose`.

## Requirements

* `Docker`
* `Docker Compose`

That's it.

## Run it

### Linux/MacOS

```shell
./compose.sh
```

### Windows

```Powershell
.\compose.ps1
```

Open your browser on

* <http://localhost:5000/swagger> for the Web API,
* <http://localhost:4200> for the Angular App and
* <http://localhost:7000> for the Mongo Express UI.

You can edit the ASP.NET Core Server and the Angular Client while they are running. They will both recompile on demand.