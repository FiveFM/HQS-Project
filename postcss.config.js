module.exports = {
    plugins: [
        require('postcss-uncss')({
            html: ['site/html/*.html'],
        }),
    ],
};
