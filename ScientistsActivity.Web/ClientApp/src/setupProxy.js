const {createProxyMiddleware} = require('http-proxy-middleware');

const target = 'http://localhost:5273';

const context = [
    "/api",
];

const onError = (err) => {
    console.error(`${err.message}`);
}

module.exports = function (app) {
    const appProxy = createProxyMiddleware(context, {
        proxyTimeout: 10000,
        target: target,
        onError: onError,
        secure: false,
    });

    app.use(appProxy);
};
