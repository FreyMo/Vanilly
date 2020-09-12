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

Just execute

```shell
./dockerize.sh
```

and open your browser on

* <http://localhost:5000/swagger> for the Web API
* <http://localhost:4200> for the Angular App
* <http://localhost:7000> for the Mongo Express UI
