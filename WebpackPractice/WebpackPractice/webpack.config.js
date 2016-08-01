const webpack = require('webpack');
var ExtractTextPlugin = require("extract-text-webpack-plugin");
var path = require('path');

var plugins = [
	//Extract style sheet to css file
    new ExtractTextPlugin('[name].css', { allChunks: true }),

	//Find the common modules and bring them to common file
     new webpack.optimize.CommonsChunkPlugin({
         name: 'common', 
     }),
];

module.exports = {

	entry: {
		common: ['./Scripts/app/app.js'],
        index: ['./Scripts/app/index.js'],
        about: ['./Scripts/app/about.js'],
    },

    output: {
        path: path.join(__dirname, 'bundle'),
        filename: "chunk.[name].js",
        publicPath: '../bundle/',
    },

    plugins: plugins,

    module: {
    	loaders: [
			//Transpile es6 to es5
            {
                test: /\.js$/,
                loader: 'babel',
                exclude: /node_modules/,
                query: {
                    presets: ['es2015']
                }
            },

			//Load style sheet file
            {
                test: /\.css$/,
                loader: ExtractTextPlugin.extract("style-loader", "css-loader")
            },
            {
                test: /\.less$/,
                loader: ExtractTextPlugin.extract("style-loader", "css-loader!less-loader")
            },

			//Tranform image to url base64 into style sheet
            { test: /\.jpe?g$|\.gif$|\.png$|\.svg$|\.woff$|\.ttf$|\.eot$/, loader: "url" }
        ]
    },
}