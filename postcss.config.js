module.exports = {
    plugins: [
        require('postcss-uncss')({
            html: ['site/html/*.html'],
            ignore: ['site/html/puppylove.html'],
        }),
    ],
};
