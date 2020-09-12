FROM node:14.4.0-alpine as dev
WORKDIR /app
EXPOSE 4200

RUN npm install -g @angular/cli

COPY package.json ./

RUN npm install --no-optional

COPY . .

CMD ng serve --host 0.0.0.0
FROM dev as build

RUN ng build --prod --outputPath=./dist/out

FROM nginx:1.17.9-alpine as final
COPY --from=build /app/dist/out/ /usr/share/nginx/html
