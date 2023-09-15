import esbuild from "esbuild";

esbuild.build({
  entryPoints: ["./Scripts/index.ts"],
  bundle: true,
  minify: false,
  format: "cjs",
  sourcemap: false,
  outfile: "./wwwroot/js/dist/scripts.js",
});
