#!/bin/bash

if [[ $1 = "-prod" ]]; then
    echo "Compose for production is not yet configured... sorry"
else
    echo "Composing for Development"
    docker-compose build --parallel
    docker-compose up --remove-orphans
fi
