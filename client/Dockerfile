FROM node:alpine
RUN npm install -g serve
WORKDIR /usr/src/app
COPY client/package*.json ./
RUN npm install
COPY client ./
RUN npm run build
EXPOSE 80
CMD ["serve", "-s", "build", "-l", "80"]
