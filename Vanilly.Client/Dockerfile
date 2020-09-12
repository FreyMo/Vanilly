FROM node:14.4.0-alpine as dev
WORKDIR /app
EXPOSE 4200

COPY package.json ./

ENV PATH /app/node_modules/.bin:$PATH

RUN npm install --no-optional

COPY . .

CMD ng serve

FROM dev as build

RUN ng build --prod --outputPath=./dist/out

FROM nginx:1.17.9-alpine as final
COPY --from=build /app/dist/out/ /usr/share/nginx/html
