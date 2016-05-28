var gulp = require('gulp');
var connect = require('gulp-connect');

gulp.task('connect', function() {
	connect.server({
		'root': './target/distro',
		'port': '4000'
	});
});
