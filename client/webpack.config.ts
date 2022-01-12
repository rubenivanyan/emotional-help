const path = require('path');

import { Configuration, DefinePlugin } from 'webpack';
import HtmlWebpackPlugin from 'html-webpack-plugin';
import ForkTsCheckerWebpackPlugin from 'fork-ts-checker-webpack-plugin';
import TsconfigPathsPlugin from 'tsconfig-paths-webpack-plugin';

const webpackConfig = (): Configuration => ({
  entry: './src/index.tsx',
  ...(process.env.production || !process.env.development ?
    {} :
    { devtool: 'eval-source-map' }),
  resolve: {
    extensions: ['.ts', '.tsx', '.js', '.scss', '.css'],
    plugins: [new TsconfigPathsPlugin({ configFile: './tsconfig.json' })],
    modules: ['node_modules'],
    alias: {
      components: path.resolve(__dirname, 'src/components/'),
      pages: path.resolve(__dirname, 'src/pages/'),
      api: path.resolve(__dirname, 'src/api/'),
      enums: path.resolve(__dirname, 'src/common/enums/'),
      types: path.resolve(__dirname, 'src/common/types/'),
    },
  },
  output: {
    publicPath: '/',
    path: path.join(__dirname, '/build'),
    filename: 'build.js',
  },
  module: {
    rules: [
      {
        test: /\.tsx?$/,
        loader: 'ts-loader',
        options: {
          transpileOnly: true,
        },
        exclude: /build/,
      },
      {
        test: /\.s?css$/,
        use: [
          'style-loader',
          'css-loader',
          {
            loader: 'sass-loader',
            options: {
              implementation: require('sass'),
            },
          },
        ],
      },
    ],
  },
  devServer: {
    port: 8080,
    open: true,
    historyApiFallback: true,
  },
  plugins: [
    new HtmlWebpackPlugin({
      template: './public/index.html',
      favicon: './public/img/favicon.png',
    }),
    new DefinePlugin({
      'process.env': process.env.production || !process.env.development,
    }),
    new ForkTsCheckerWebpackPlugin({
      eslint: {
        files: './src/**/*.{ts,tsx,js,jsx}',
      },
    }),
  ],
});

export default webpackConfig;
