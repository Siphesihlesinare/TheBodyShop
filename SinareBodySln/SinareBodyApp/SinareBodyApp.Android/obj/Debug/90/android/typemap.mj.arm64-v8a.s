	/* Data SHA1: 30e478ab2f097b45a231b8b248c4aa241c910326 */
	.arch	armv8-a
	.file	"typemap.mj.inc"

	/* Mapping header */
	.section	.data.mj_typemap,"aw",@progbits
	.type	mj_typemap_header, @object
	.p2align	2
	.global	mj_typemap_header
mj_typemap_header:
	/* version */
	.word	1
	/* entry-count */
	.word	1428
	/* entry-length */
	.word	262
	/* value-offset */
	.word	145
	.size	mj_typemap_header, 16

	/* Mapping data */
	.type	mj_typemap, @object
	.global	mj_typemap
mj_typemap:
	.size	mj_typemap, 374137
	.include	"typemap.mj.inc"
